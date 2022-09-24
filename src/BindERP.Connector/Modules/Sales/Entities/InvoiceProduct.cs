namespace BindERP.Connector.Modules.Sales.Entities;

public record InvoiceProduct
{
    public Guid ID
    {
        get;
        set;
    }

    public Guid ProductID
    {
        get;
        set;
    }

    public string? Name
    {
        get;
        set;
    }

    public long? IndexNumber
    {
        get;
        set;
    }

    public string? Code
    {
        get;
        set;
    }

    public string? Unit
    {
        get;
        set;
    }

    public decimal? UnitMultiplier
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
    public decimal? VATRate
    {
        get;
        set;
    }
    public decimal? IEPSRate
    {
        get;
        set;
    }
    public decimal? Discount
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public string? LotInfo
    {
        get;
        set;
    }
}
