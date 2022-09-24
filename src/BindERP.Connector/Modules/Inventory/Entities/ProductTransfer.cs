namespace BindERP.Connector.Modules.Inventory.Entities;

public record ProductTransfer
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

    public string? Code
    {
        get;
        set;
    }

    public decimal? Received
    {
        get;
        set;
    }

    public decimal? Shipping
    {
        get;
        set;
    }
}
