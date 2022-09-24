using BindERP.Connector.Modules.Accounting.Contracts;

namespace BindERP.Connector.Modules.Accounting;

public interface IAccountingModule
{
    public IAccountCategoriesService AccountCategoriesService
    {
        get;
    }

    public IAccountsService AccountsService
    {
        get;
    }

    public IJournalsService JournalsService
    {
        get;
    }
}
