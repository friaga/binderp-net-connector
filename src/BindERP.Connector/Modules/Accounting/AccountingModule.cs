using BindERP.Connector.Modules.Accounting.Contracts;

namespace BindERP.Connector.Modules.Accounting;

public class AccountingModule : IAccountingModule
{
    public AccountingModule(IAccountCategoriesService categories, IAccountsService accounts, IJournalsService journals)
    {
        AccountCategoriesService = categories;
        AccountsService          = accounts;
        JournalsService          = journals;
    }

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
