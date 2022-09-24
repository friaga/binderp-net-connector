namespace BindERP.Connector.Modules.Sales.Entities;

public record ProductInventory
{
    public string? WarehouseName
    {
        get;
        set;
    }

    public long? Min
    {
        get;
        set;
    }

    public long? Max
    {
        get;
        set;
    }

    public string? Location
    {
        get;
        set;
    }

    public bool? Visible
    {
        get;
        set;
    }

    public decimal? Inventory
    {
        get;
        set;
    }
}
