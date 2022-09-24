namespace BindERP.Connector.Modules.Core.Entities;

public record PriceList
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
