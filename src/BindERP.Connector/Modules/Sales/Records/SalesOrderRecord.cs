namespace BindERP.Connector.Modules.Sales.Records;

public record SalesOrderRecord
{
    public Guid? ID
    {
        get;
        set;
    }

    public Guid? ClientID
    {
        get;
        set;
    }

    public string? ClientName
    {
        get;
        set;
    }

    public string? PriceListName
    {
        get;
        set;
    }

    public Guid? PriceListID
    {
        get;
        set;
    }

    public string? LocationName
    {
        get;
        set;
    }

    public Guid? LocationID
    {
        get;
        set;
    }

    public Guid? WarehouseID
    {
        get;
        set;
    }

    public string? WarehouseName
    {
        get;
        set;
    }

    public DateTime? OrderDate
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public long? Number
    {
        get;
        set;
    }

    public string? ClientContact
    {
        get;
        set;
    }

    public string? PhoneNumber
    {
        get;
        set;
    }

    public string? EmployeeName
    {
        get;
        set;
    }

    public Guid? EmployeeID
    {
        get;
        set;
    }

    public string? PurchaseOrder
    {
        get;
        set;
    }

    public int? Status
    {
        get;
        set;
    }

    public string? CurrencyName
    {
        get;
        set;
    }

    public Guid? CurrencyID
    {
        get;
        set;
    }

    public decimal? ExchangeRate
    {
        get;
        set;
    }

    public string? RFC
    {
        get;
        set;
    }

    public decimal? ServiceSubtotal
    {
        get;
        set;
    }

    public decimal? ProductSubtotal
    {
        get;
        set;
    }

    public string? Serie
    {
        get;
        set;
    }

    public decimal? Discount
    {
        get;
        set;
    }

    public decimal? VATRate
    {
        get;
        set;
    }

    public decimal? VAT
    {
        get;
        set;
    }

    public int? DiscountType
    {
        get;
        set;
    }

    public decimal? IEPS
    {
        get;
        set;
    }

    public decimal? IEPSRATE
    {
        get;
        set;
    }

    public decimal? ISRRet
    {
        get;
        set;
    }

    public decimal? ISRRetRate
    {
        get;
        set;
    }

    public decimal? VatRet
    {
        get;
        set;
    }

    public decimal? VatRetRate
    {
        get;
        set;
    }

    public decimal? Total
    {
        get;
        set;
    }
}
