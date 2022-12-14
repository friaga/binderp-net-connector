using BindERP.Connector.Modules.Webhooks.Contracts;

namespace BindERP.Connector.Modules.Webhooks;

public class WebhooksModule : IWebhooksModule
{
    public WebhooksModule(ISubscriptionsService subscriptions)
    {
        this.SubscriptionsService = subscriptions;
    }

    public ISubscriptionsService SubscriptionsService
    {
        get;
    }
}
