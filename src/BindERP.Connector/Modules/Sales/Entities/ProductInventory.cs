namespace BindERP.Connector.Modules.Sales.Entities;

public record ProductInventory
{
    public string? WarehouseName
    {
        get;
        set;
    }

    public decimal? Min
    {
        get;
        set;
    }

    public decimal? Max
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
