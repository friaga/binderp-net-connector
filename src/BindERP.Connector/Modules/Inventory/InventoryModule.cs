using BindERP.Connector.Modules.Inventory.Contracts;

namespace BindERP.Connector.Modules.Inventory;

internal class InventoryModule : IInventoryModule
{
    public InventoryModule(IWarehousesService warehouses)
    {
        WarehousesService = warehouses;
    }

    public IWarehousesService WarehousesService
    {
        get;
    }
}
