using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Communications.Contracts;
using BindERP.Connector.Modules.Communications.Entities;

namespace BindERP.Connector.Modules.Communications.Services;

/// <summary>
/// Representa el servicio de actividades.
/// </summary>
public class ActivitiesService : BaseService, IActivitiesService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="ActivitiesService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public ActivitiesService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de actividades.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de actividades.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<Activity>?> GetActivitiesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<Activity>>($"/api/Activities", criteria, cancellationToken);
    }
}
