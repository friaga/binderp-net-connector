namespace BindERP.Connector.Modules.Sales.Entities;

public record SalesOrder
{
    public SalesOrder()
    {
        this.Products = new List<SalesOrderProduct>();
        this.Services = new List<SalesOrderService>();
    }

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

    public string? Address
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

    public int? StatusCode
    {
        get;
        set;
    }

    public string? PurchaseOrder
    {
        get;
        set;
    }

    public string? Status
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

    public decimal? DiscountType
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


    public IEnumerable<SalesOrderProduct> Products
    {
        get;
    }

    public IEnumerable<SalesOrderService> Services
    {
        get;
    }
}
