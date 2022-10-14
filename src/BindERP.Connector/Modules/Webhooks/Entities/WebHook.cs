namespace BindERP.Connector.Modules.Webhooks.Entities;

public record WebHook
{
    public string? ID
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
