using BindERP.Connector.Common;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Contracts;

/// <summary>
/// Representa la interfase del servicio de tipos de cambio.
/// </summary>
public interface ICurrenciesService
{
    /// <summary>
    /// Obtiene una página de tipos de cambio.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de tipos de cambio.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<Currency>?> GetCurrenciesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);
}
