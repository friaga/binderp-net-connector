namespace BindERP.Connector.Modules.Sales.Entities;

public record Service
{
    public string? Category1
    {
        get;
        set;
    }

    public Guid? Category1ID
    {
        get;
        set;
    }

    public string? Category2
    {
        get;
        set;
    }

    public Guid? Category2ID
    {
        get;
        set;
    }

    public string? Category3
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

    public string? Code
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public string? CurrencyCode
    {
        get;
        set;
    }

    public Guid? CurrencyID
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public Guid? ID
    {
        get;
        set;
    }

    public object? Prices
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

    public string? Title
    {
        get;
        set;
    }

    public string? Unit
    {
        get;
        set;
    }

    public bool? VariableConcept
    {
        get;
        set;
    }
}
