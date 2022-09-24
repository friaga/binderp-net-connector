using Microsoft.Extensions.Options;

namespace BindERP.Connector
{
    internal class BindConnection : IDisposable, IBindConnection
    {
        private HttpClient? client;
        private bool disposed;

        private readonly BindOptions options;

        private readonly IHttpClientFactory factory;

        public BindConnection(IHttpClientFactory factory, IOptions<BindOptions> options)
        {
            this.factory = factory;
            this.options = options.Value;
        }

        public HttpClient GetClient()
        {
            if (this.client is not null)
            {
                return this.client;
            }

            this.client = factory.CreateClient("bind-api-client");

            var endpoint     = options.EndpointUri ?? string.Empty;
            var token        = options.EndpointKey ?? string.Empty;
            var subscription = options.SubscriptionKey ?? string.Empty;

            if (!Uri.TryCreate(endpoint, UriKind.Absolute, out var endpointUri))
            {
                endpointUri = new Uri("https://api.bind.com.mx", UriKind.Absolute);
            }

            token        = token.Trim();
            subscription = subscription.Trim();

            if (string.IsNullOrWhiteSpace(token))
            {
                throw new InvalidOperationException("The Bind ERP API key is not valid. Please ensure it's in the appropiate configuration section.");
            }

            this.client.BaseAddress = endpointUri;
            this.client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            if (!string.IsNullOrWhiteSpace(subscription))
            {
                this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{subscription}");
            }

            return this.client;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (this.client is not null)
                    {
                        this.client.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BindConnection()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
