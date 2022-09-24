using BindERP.Connector.Modules.Purchasing.Contracts;

namespace BindERP.Connector.Modules.Purchasing;

internal class PurchasingModule : IPurchasingModule
{
    public PurchasingModule(IExpensesService expenses, IProvidersService providers, IPurchaseOrdersService orders)
    {
        this.ExpensesService         = expenses;
        this.ProvidersService        = providers;
        this.PurchaseOrdersService   = orders;
    }

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
