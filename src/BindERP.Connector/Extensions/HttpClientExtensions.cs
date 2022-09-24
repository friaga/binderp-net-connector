using BindERP.Connector.Common;
using Newtonsoft.Json;

namespace BindERP.Connector.Extensions
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operacion.</exception>
        /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operacion.</exception>
        /// <exception cref="TaskCanceledException">Lanzada cuando la operacion es cancelada.</exception>
        public static async Task<T?> GetAsync<T>(this HttpClient client, string requestUri, CancellationToken cancellationToken = default)
        {
            var response = await client.GetAsync(requestUri, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                var raw = await response.Content.ReadAsStringAsync(cancellationToken);
                if (raw is not null)
                {
                    var error = JsonConvert.DeserializeObject<ErrorRecord>(raw);
                    if (error is not null)
                    {
                        throw new InvalidOperationException(error.Message ?? "Ha ocurrido un error al intentar obtener una solicitud.");
                    }
                }

                throw new InvalidOperationException("Ha ocurrido un error al intentar obtener una solicitud.");
            }

            var json = await response.Content.ReadAsStringAsync(cancellationToken);
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new InvalidOperationException("Ha ocurrido un error al intentar obtener un cliente.");
            }

            T? result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="requestUri"></param>
        /// <param name="criteria"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operacion.</exception>
        /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operacion.</exception>
        /// <exception cref="TaskCanceledException">Lanzada cuando la operacion es cancelada.</exception>
        public static async Task<T?> GetAsync<T>(this HttpClient client, string requestUri, SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
        {
            var query       = criteria?.ToQueryString() ?? string.Empty;
            var separator   = (requestUri ?? string.Empty).Contains('?', StringComparison.Ordinal) ? "&" : "?";

            var filter = string.Empty;
            if (!string.IsNullOrWhiteSpace(query))
            {
                filter = $"{separator}{query}";
            }

            var filteredUri = new Uri($"{requestUri}{filter}", UriKind.Relative);

            var response = await client.GetAsync(filteredUri, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException("Ha ocurrido un error al intentar obtener un cliente.");
            }

            var json = await response.Content.ReadAsStringAsync(cancellationToken);
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new InvalidOperationException("Ha ocurrido un error al intentar obtener un cliente.");
            }

            T? result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }

    }
}
