using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Core.Contracts;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Services;

/// <summary>
/// Representa el servicio de las series.
/// </summary>
public class SeriesService : BaseService, ISeriesService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="SeriesService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public SeriesService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene las series de los tipos de documentos proporcionados.
    /// </summary>
    /// <param name="documentType">El tipo de documento a obtener.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>Las categorias del sistema.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<IEnumerable<Series>?> GetSeriesAsync(int documentType, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<IEnumerable<Series>>($"/api/Series?docType={documentType}", cancellationToken);
    }
}
