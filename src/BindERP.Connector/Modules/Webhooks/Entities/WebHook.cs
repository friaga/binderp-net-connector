namespace BindERP.Connector.Modules.Webhooks.Entities;

public record WebHook
{
    public Guid ID
    {
        get;
        set;
    }

    public string? EventName
    {
        get;
        set;
    }

    public string? EventDescription
    {
        get;
        set;
    }
}
