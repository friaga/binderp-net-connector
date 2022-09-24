namespace BindERP.Connector.Modules.Sales.Entities;

public record Invoice
{
    public Invoice()
    {
        this.Products = new List<InvoiceProduct>();
        this.Services = new List<InvoiceService>();
    }

    public Guid? ID
    {
        get;
        set;
    }

    public Guid? UUID
    {
        get;
        set;
    }

    public string? Series
    {
        get;
        set;
    }

    public long? Number
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

    public long? PaymentTerms
    {
        get;
        set;
    }

    public string? Status
    {
        get;
        set;
    }

    public int? StatusCode
    {
        get;
        set;
    }

    public string? ClientPhoneNumber
    {
        get;
        set;
    }

    public string? ClientContact
    {
        get;
        set;
    }

    public string? RFC
    {
        get;
        set;
    }

    public Guid? CreatedByID
    {
        get;
        set;
    }

    public string? CreatedByName
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public DateTime? ApplicationDate
    {
        get;
        set;
    }

    public Guid? PriceListID
    {
        get;
        set;
    }

    public string? PriceListName
    {
        get;
        set;
    }

    public Guid? LocationID
    {
        get;
        set;
    }

    public string? LocationName
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

    public string? CFDIPaymentMethod
    {
        get;
        set;
    }

    public string? CFDIPaymentTerm
    {
        get;
        set;
    }

    public string? CFDIAccountNumber
    {
        get;
        set;
    }

    public string? CurrencyName
    {
        get;
        set;
    }

    public decimal? ExchangeRate
    {
        get;
        set;
    }

    public string? PurchaseOrder
    {
        get;
        set;
    }

    public Guid? FiscalID
    {
        get;
        set;
    }

    public string? Address
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public decimal? Subtotal
    {
        get;
        set;
    }

    public decimal? Discount
    {
        get;
        set;
    }

    public decimal? VAT
    {
        get;
        set;
    }

    public decimal? IEPS
    {
        get;
        set;
    }

    public decimal? VATRet
    {
        get;
        set;
    }
    public decimal? ISRRet
    {
        get;
        set;
    }

    public decimal? Payments
    {
        get;
        set;
    }

    public decimal? CreditNotes
    {
        get;
        set;
    }

    public IEnumerable<InvoiceProduct> Products
    {
        get;
    }

    public IEnumerable<InvoiceService> Services
    {
        get;
    }
}
