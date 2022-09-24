using BindERP.Connector.Modules.Inventory.Contracts;

namespace BindERP.Connector.Modules.Inventory;

public interface IInventoryModule
{
    public IWarehousesService WarehousesService
    {
        get;
    }
}
