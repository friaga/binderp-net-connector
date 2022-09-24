using BindERP.Connector.Modules.Webhooks.Contracts;

namespace BindERP.Connector.Modules.Webhooks;

public interface IWebhooksModule
{
    public ISubscriptionsService SubscriptionsService
    {
        get;
    }
}
