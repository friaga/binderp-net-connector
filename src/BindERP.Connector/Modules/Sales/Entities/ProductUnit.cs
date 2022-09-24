namespace BindERP.Connector.Modules.Sales.Entities;

public record ProductUnit
{
    public string? Name
    {
        get;
        set;
    }
    public decimal? Multiplier
    {
        get;
        set;
    }

    public bool? SalesUnit
    {
        get;
        set;
    }

    public bool? PurchaseUnit
    {
        get;
        set;
    }
}
