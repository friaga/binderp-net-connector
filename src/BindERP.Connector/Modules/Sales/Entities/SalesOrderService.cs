namespace BindERP.Connector.Modules.Sales.Entities;

public record SalesOrderService
{
    public long? IndexNumber
    {
        get;
        set;
    }

    public Guid? ServiceID
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
}
