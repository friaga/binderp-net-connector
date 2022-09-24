using BindERP.Connector.Common;
using BindERP.Connector.Modules.Inventory.Entities;

namespace BindERP.Connector.Modules.Inventory.Contracts;

public interface IWarehousesService
{
    /// <summary>
    /// Obtiene una página de almacenes.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de almacenes.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<Warehouse>?> GetWarehousesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de transferencias de mercancias.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de transferencia de mercancia.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<MerchandiseTransfer>?> GetMerchandiseTransfersPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de inventario de almacen.
    /// </summary>
    /// <param name="warehouseID">El identificador del almacen.</param>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de inventario de almacen.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<WarehouseInventory>?> GetWarehouseInventoryPageAsync(Guid warehouseID, SearchCriteria? criteria = null, CancellationToken cancellationToken = default);


    /// <summary>
    /// Obtiene una página de recepciones de mercancia.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de recepciones de mercancia.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<WarehouseReception>?> GetWarehouseReceptionsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene el detalle de un producto y sus precios a partir del almacen y lista de precios.
    /// </summary>
    /// <param name="warehouseID">El identificador del almacen.</param>
    /// <param name="priceListID">El identificador de la lista de precios.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>El detalle del stock de un producto con sus precios.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<List<ProductStock>?> GetWarehouseProductStockAsync(Guid warehouseID, Guid priceListID, CancellationToken cancellationToken = default);





    //Task<Guid?> CreateMerchandiseTransferAsync(object transfer, CancellationToken cancellationToken = default);

    //Task<bool?> CompleteMerchandiseTransferAsync(object transfer, CancellationToken cancellationToken = default);



    //Task<bool?> CreateAdjustsmentAsync(object adjustment, CancellationToken cancellationToken = default);

    //Task<Guid?> CreateReceptionAsync(object reception, CancellationToken cancellationToken = default);
}
