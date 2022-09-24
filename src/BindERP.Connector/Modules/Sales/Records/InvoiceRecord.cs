namespace BindERP.Connector.Modules.Sales.Records;

public record InvoiceRecord
{
    public Guid ID
    {
        get;
        set;
    }

    public string? Serie
    {
        get;
        set;
    }

    public DateTime? Date
    {
        get;
        set;
    }
    public long? Number
    {
        get;
        set;
    }

    public Guid? UUID
    {
        get;
        set;
    }

    public DateTime? ExpirationDate
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

    public string? RFC
    {
        get;
        set;
    }

    public decimal? Cost
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

    public decimal? ISRRet
    {
        get;
        set;
    }

    public decimal? VATRet
    {
        get;
        set;
    }

    public decimal? Total
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

    public Guid? CurrencyID
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

    public Guid? PriceListID
    {
        get;
        set;
    }

    public long? CFDIUse
    {
        get;
        set;
    }

    public decimal? ExchangeRate
    {
        get;
        set;
    }

    public decimal? VATRetRate
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public decimal? VATRate
    {
        get;
        set;
    }

    public string? PurchaseOrder
    {
        get;
        set;
    }

    public bool? IsFiscalInvoice
    {
        get;
        set;
    }

    public bool? ShowIEPS
    {
        get;
        set;
    }

    public int? Status
    {
        get;
        set;
    }
}
