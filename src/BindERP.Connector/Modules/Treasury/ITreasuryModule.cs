using BindERP.Connector.Modules.Treasury.Contracts;

namespace BindERP.Connector.Modules.Treasury;

public interface ITreasuryModule
{
    public IBankAccountsService BankAccountsService
    {
        get;
    }
}
