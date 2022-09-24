namespace BindERP.Connector.Modules.Inventory.Entities;

public record Warehouse
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

    public Guid LocationID
    {
        get;
        set;
    }

    public bool? AvailableInOtherLoc
    {
        get;
        set;
    }
}
