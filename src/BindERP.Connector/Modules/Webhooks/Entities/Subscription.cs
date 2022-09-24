namespace BindERP.Connector.Modules.Webhooks.Entities;

public record Subscription
{
    public Guid? ID
    {
        get;
        set;
    }

    public string? EventID
    {
        get;
        set;
    }

    public string? TargetURL
    {
        get;
        set;
    }

    public string? EventName
    {
        get;
        set;
    }
}
