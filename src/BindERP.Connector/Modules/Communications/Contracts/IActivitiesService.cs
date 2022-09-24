using BindERP.Connector.Common;
using BindERP.Connector.Modules.Communications.Entities;

namespace BindERP.Connector.Modules.Communications.Contracts;

/// <summary>
/// Representa la interfase del servicio de actividades.
/// </summary>
public interface IActivitiesService
{
    /// <summary>
    /// Obtiene una página de actividades.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de actividades.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<Activity>?> GetActivitiesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);


    //Task<bool?> CreateActivityAsync(object activity, CancellationToken cancellationToken = default);
}
