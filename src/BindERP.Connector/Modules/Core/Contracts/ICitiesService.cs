using BindERP.Connector.Common;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Contracts;

/// <summary>
/// Representa la interfase del servicio de ciudades.
/// </summary>
public interface ICitiesService
{
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
    Task<Page<City>?> GetCitiesPageAsync(Guid stateID, SearchCriteria? criteria = null, CancellationToken cancellationToken = default);
}
