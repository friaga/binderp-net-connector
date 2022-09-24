namespace BindERP.Connector.Modules.Sales.Records;

public record QuoteRecord
{
    public Guid? ID
    {
        get;
        set;
    }

    public string? Number
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public string? ClientName
    {
        get;
        set;
    }

    public string? Locations
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public decimal? TotalOriginalCurrency
    {
        get;
        set;
    }

    public string? Currency
    {
        get;
        set;
    }

    public int? Status
    {
        get;
        set;
    }

    public decimal? Total
    {
        get;
        set;
    }

    public string? StatusText
    {
        get;
        set;
    }
}
