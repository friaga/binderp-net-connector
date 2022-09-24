namespace BindERP.Connector.Modules.Inventory.Entities;

public record WarehouseInventory
{
    public Guid ID
    {
        get;
        set;
    }

    public decimal? Balance
    {
        get;
        set;
    }

    public decimal? ClientOrdered
    {
        get;
        set;
    }

    public decimal? CurrentInventory
    {
        get;
        set;
    }

    public string? Location
    {
        get;
        set;
    }

    public decimal? ProvidedOrdered
    {
        get;
        set;
    }

    public string? SKU
    {
        get;
        set;
    }

    public string? Title
    {
        get;
        set;
    }

    public decimal? Value
    {
        get;
        set;
    }

    public string? Code
    {
        get;
        set;
    }

    public Guid? ProductID
    {
        get;
        set;
    }

    public bool? Visible
    {
        get;
        set;
    }
}
