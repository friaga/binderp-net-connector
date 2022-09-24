namespace BindERP.Connector.Modules.Core.Entities;

public record State
{
    public Guid ID
    {
        get;
        set;
    }

    public string? Name
    {
        get;
        set;
    }
}
