namespace BindERP.Connector.Modules.Inventory.Entities;

public record ProductStock
{
    public ProductStock()
    {
        this.LotImports   = new List<ProductLotImport>();
        this.VolumePrices = new List<ProductVolumePrice>();
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

    public long? Number
    {
        get;
        set;
    }

    public decimal? Price
    {
        get;
        set;
    }

    public decimal? VAT
    {
        get;
        set;
    }

    public Guid? Cat1ID
    {
        get;
        set;
    }

    public Guid? Cat2ID
    {
        get;
        set;
    }

    public Guid? Cat3ID
    {
        get;
        set;
    }

    public string? PricingTypeText
    {
        get;
        set;
    }

    public decimal? Inventory
    {
        get;
        set;
    }

    public int? IEPSType
    {
        get;
        set;
    }

    public decimal? IEPS
    {
        get;
        set;
    }

    public string? SKU
    {
        get;
        set;
    }
    public string? Descripcion
    {
        get;
        set;
    }

    public bool? VATExempt
    {
        get;
        set;
    }

    public decimal? Min
    {
        get;
        set;
    }

    public decimal? Max
    {
        get;
        set;
    }

    public IEnumerable<ProductLotImport> LotImports
    {
        get;
    }

    public IEnumerable<ProductVolumePrice> VolumePrices
    {
        get;
    }
}
