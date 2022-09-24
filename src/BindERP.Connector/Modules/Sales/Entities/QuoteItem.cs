namespace BindERP.Connector.Modules.Sales.Entities;

public record QuoteItem
{
    public Guid? ID
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

    public string? ProductName
    {
        get;
        set;
    }


    public string? Unit
    {
        get;
        set;
    }


    public decimal? Qty
    {
        get;
        set;
    }

    public decimal? Price
    {
        get;
        set;
    }

    public decimal? Amount
    {
        get;
        set;
    }


    public decimal? IEPS
    {
        get;
        set;
    }

    public decimal? VAT
    {
        get;
        set;
    }

    public int? IndexNumber
    {
        get;
        set;
    }
}
