namespace BindERP.Connector.Modules.Sales.Entities;

public record FormulaProduct
{
    public Guid ID
    {
        get;
        set;
    }

    public Guid? ProductID
    {
        get;
        set;
    }

    public decimal? Qty
    {
        get;
        set;
    }

    public long? IndexNumber
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public string? Code
    {
        get;
        set;
    }

    public string? Title
    {
        get;
        set;
    }
}
