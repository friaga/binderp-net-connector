namespace BindERP.Connector.Modules.Sales.Records;

public record FormulaRecord
{
    public Guid ID
    {
        get;
        set;
    }

    public string? Title
    {
        get;
        set;
    }

    public Guid? ProductID
    {
        get;
        set;
    }

    public string? ProductTitle
    {
        get;
        set;
    }

    public decimal? Qty
    {
        get;
        set;
    }

    public decimal? AdditionalCosts
    {
        get;
        set;
    }
}
