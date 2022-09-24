namespace BindERP.Connector.Modules.Inventory.Entities;

public record MerchandiseTransfer
{
    public MerchandiseTransfer()
    {
        this.ProductsTransfers = new List<ProductTransfer>();
    }

    public string? ID
    {
        get;
        set;
    }

    public long? Number
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public string? SourceWarehouse
    {
        get;
        set;
    }
    public string? DestinationWarehouse
    {
        get;
        set;
    }

    public decimal? ProductsCount
    {
        get;
        set;
    }

    public decimal? Units
    {
        get;
        set;
    }

    public decimal? Amount
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public string? Status
    {
        get;
        set;
    }

    public string? StatusText
    {
        get;
        set;
    }

    public IEnumerable<ProductTransfer> ProductsTransfers
    {
        get;
    }
}
