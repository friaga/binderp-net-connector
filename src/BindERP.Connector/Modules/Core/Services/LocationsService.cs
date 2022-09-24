using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Core.Contracts;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Services;

/// <summary>
/// Representa el servicio de las sucursales.
/// </summary>
internal class LocationsService : BaseService, ILocationsService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="LocationsService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public LocationsService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de sucursales.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de sucursales.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<Location>?> GetLocationsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<Location>>($"/api/Locations", criteria, cancellationToken);
    }
}
