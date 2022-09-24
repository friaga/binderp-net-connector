namespace BindERP.Connector.Modules.Sales.Records;

public record ProductRecord
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

    public decimal? Cost
    {
        get;
        set;
    }

    public string? SKU
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public int? CostType
    {
        get;
        set;
    }

    public string? CostTypeText
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

    public decimal? CurrentInventory
    {
        get;
        set;
    }

    public bool? ChargeVAT
    {
        get;
        set;
    }

    public long? Number
    {
        get;
        set;
    }

    public int? PricingType
    {
        get;
        set;
    }

    public string? ImageUrl
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

    public int? PurchaseType
    {
        get;
        set;
    }

    public string? PurchaseTypeText
    {
        get;
        set;
    }

    public decimal? IEPSRate
    {
        get;
        set;
    }

    public int? Type
    {
        get;
        set;
    }

    public string? TypeText
    {
        get;
        set;
    }

    public bool? ProductionAuto
    {
        get;
        set;
    }

    public decimal? Volume
    {
        get;
        set;
    }

    public decimal? Weight
    {
        get;
        set;
    }
}
