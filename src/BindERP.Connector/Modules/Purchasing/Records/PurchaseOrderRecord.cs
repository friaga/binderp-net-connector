namespace BindERP.Connector.Modules.Purchasing.Records;

public record PurchaseOrderRecord
{
    public Guid ID
    {
        get;
        set;
    }

    public long? Number
    {
        get;
        set;
    }

    public string? Warehouse
    {
        get;
        set;
    }

    public string? Provider
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public int? Status
    {
        get;
        set;
    }

    public bool? BaseCurrency
    {
        get;
        set;
    }

    public decimal? ProductQty
    {
        get;
        set;
    }

    public decimal? ProductQtyMissed
    {
        get;
        set;
    }

    public bool? Selected
    {
        get;
        set;
    }

    public bool? HasReceptions
    {
        get;
        set;
    }

    public decimal? TotalImport
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

    public string? StatusText
    {
        get;
        set;
    }

    public Guid? ProviderID
    {
        get;
        set;
    }
}
