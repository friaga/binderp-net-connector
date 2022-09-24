using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Purchasing.Contracts;
using BindERP.Connector.Modules.Purchasing.Entities;
using BindERP.Connector.Modules.Purchasing.Records;

namespace BindERP.Connector.Modules.Purchasing.Services;

public class PurchaseOrdersService : BaseService, IPurchaseOrdersService
{
    public PurchaseOrdersService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de ordenes de compra.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de ordenes de compra.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<PurchaseOrderRecord>?> GetPurchaseOrdersPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<PurchaseOrderRecord>>($"/api/Purchases/GetPurchaseOrders", criteria, cancellationToken);
    }
}
