namespace BindERP.Connector.Modules.Sales.Entities;

public record Product
{
    public Product()
    {
        this.Inventories      = new List<ProductInventory>();
        this.AlternativeUnits = new List<ProductUnit>();
    }

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

    public Guid? Category1ID
    {
        get;
        set;
    }

    public string? Category1
    {
        get;
        set;
    }

    public Guid? Category2ID
    {
        get;
        set;
    }

    public string? Category2
    {
        get;
        set;
    }

    public Guid? Category3ID
    {
        get;
        set;
    }

    public string? Category3
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

    public int? Number
    {
        get;
        set;
    }

    public int? PricingType
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

    public string? ImageUrl
    {
        get;
        set;
    }

    public ProductPrice? Prices
    {
        get;
        set;
    }

    public IEnumerable<ProductInventory> Inventories
    {
        get;
    }

    public IEnumerable<ProductUnit> AlternativeUnits
    {
        get;
    }
}
