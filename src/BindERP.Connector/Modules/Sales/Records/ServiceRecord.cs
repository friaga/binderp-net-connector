namespace BindERP.Connector.Modules.Sales.Records;

public record ServiceRecord
{
    public Guid ID
    {
        get;
        set;
    }

    public string? Code
    {
        get;
        set;
    }

    public decimal? Cost
    {
        get;
        set;
    }

    public string? Title
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public Guid? Category1ID
    {
        get;
        set;
    }

    public Guid? Category2ID
    {
        get;
        set;
    }

    public Guid? Category3ID
    {
        get;
        set;
    }

    public bool? ChargeVAT
    {
        get;
        set;
    }

    public int? PricingType
    {
        get;
        set;
    }

    public string? PricingTypeText
    {
        get;
        set;
    }

    public string? Unit
    {
        get;
        set;
    }

    public Guid? CurrencyID
    {
        get;
        set;
    }

    public string? CurrencyCode
    {
        get;
        set;
    }

    public bool? VariableConcept
    {
        get;
        set;
    }

    public long? SATCode
    {
        get;
        set;
    }

    public long? SATUnit
    {
        get;
        set;
    }

}
