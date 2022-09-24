namespace BindERP.Connector.Modules.Webhooks.Models;

public record SubscriptionDeletionModel
{
    public string? ID
    {
        get;
        set;
    }

    public Guid? SubscriptionID
    {
        get;
        set;
    }
}
