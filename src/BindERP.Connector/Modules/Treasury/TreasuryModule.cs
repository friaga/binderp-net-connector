using BindERP.Connector.Modules.Treasury.Contracts;

namespace BindERP.Connector.Modules.Treasury;

internal class TreasuryModule : ITreasuryModule
{
    public TreasuryModule(IBankAccountsService accounts)
    {
        this.BankAccountsService = accounts;
    }

    public IBankAccountsService BankAccountsService
    {
        get;
    }
}
