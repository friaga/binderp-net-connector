using BindERP.Connector.Modules.Purchasing.Contracts;

namespace BindERP.Connector.Modules.Purchasing;

public interface IPurchasingModule
{
    public IExpensesService ExpensesService
    {
        get;
    }

    public IProvidersService ProvidersService
    {
        get;
    }

    public IPurchaseOrdersService PurchaseOrdersService
    {
        get;
    }
}
