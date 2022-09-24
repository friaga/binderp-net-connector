using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Core.Contracts;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Services;

/// <summary>
/// Representa el servicio de las ciudades.
/// </summary>
internal class CitiesService : BaseService, ICitiesService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="CitiesService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public CitiesService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de ciudades.
    /// </summary>
    /// <param name="stateID">El identificador de la entidad federativa.</param>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de ciudades.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<City>?> GetCitiesPageAsync(Guid stateID, SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<City>>($"/api/Cities?stateID={stateID}", criteria, cancellationToken);
    }
}
