using BindERP.Connector.Modules.Accounting;
using BindERP.Connector.Modules.Communications;
using BindERP.Connector.Modules.Core;
using BindERP.Connector.Modules.Inventory;
using BindERP.Connector.Modules.Purchasing;
using BindERP.Connector.Modules.Sales;
using BindERP.Connector.Modules.Treasury;
using BindERP.Connector.Modules.Webhooks;

namespace BindERP.Connector;

public class BindClient : IBindClient
{
    public BindClient(IAccountingModule accounting, ICoreModule core, ICommunicationsModule communications, IInventoryModule inventory, IPurchasingModule purchasing, ISalesModule sales, ITreasuryModule treasury, IWebhooksModule webhooks)
    {
        this.AccountingServices     = accounting;
        this.CoreServices           = core;
        this.CommunicationsServices = communications;
        this.InventoryServices      = inventory;
        this.PurchasingServices     = purchasing;
        this.SalesServices          = sales;
        this.TreasuryServices       = treasury;
        this.WebhooksServices       = webhooks;
    }

    public IAccountingModule AccountingServices
    {
        get;
    }

    public ICoreModule CoreServices
    {
        get;
    }

    public ICommunicationsModule CommunicationsServices
    {
        get;
    }

    public IInventoryModule InventoryServices
    {
        get;
    }

    public IPurchasingModule PurchasingServices
    {
        get;
    }

    public ISalesModule SalesServices
    {
        get;
    }

    public ITreasuryModule TreasuryServices
    {
        get;
    }

    public IWebhooksModule WebhooksServices
    {
        get;
    }
}
