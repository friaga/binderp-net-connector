namespace BindERP.Connector.Modules.Sales.Entities;

public record ProductPriceItem
{
    public string? Name
    {
        get;
        set;
    }

    public decimal? Margin
    {
        get;
        set;
    }

    public decimal? Price
    {
        get;
        set;
    }

    public string? CurrencyCode
    {
        get;
        set;
    }

    public int? Type
    {
        get;
        set;
    }
}
