using BindERP.Connector.Common;
using BindERP.Connector.Modules.Purchasing.Records;

namespace BindERP.Connector.Modules.Purchasing.Contracts;

public interface IPurchaseOrdersService
{
    /// <summary>
    /// Obtiene una página de ordenes de compra.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de ordenes de compra.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<PurchaseOrderRecord>?> GetPurchaseOrdersPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);


    //Task<Guid?> CreatePurchaseOrderAsync(object purchaseOrder, CancellationToken cancellationToken = default);
}
