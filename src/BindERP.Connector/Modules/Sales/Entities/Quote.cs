namespace BindERP.Connector.Modules.Sales.Entities;

public record Quote
{
    public Quote()
    {
        this.Items = new List<QuoteItem>();
    }

    public Guid? ID
    {
        get;
        set;
    }

    public string? QuoteNumber
    {
        get;
        set;
    }

    public string? ClientName
    {
        get;
        set;
    }

    public string? ClientContact
    {
        get;
        set;
    }

    public Guid? ClientID
    {
        get;
        set;
    }

    public string? ClientPhone
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

    public string? CurrencyCode
    {
        get;
        set;
    }
    public decimal? ExchangeRate
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

    public string? StatusText
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

    public decimal? IEPS
    {
        get;
        set;
    }

    public decimal? VAT
    {
        get;
        set;
    }

    public decimal? VATRate
    {
        get;
        set;
    }

    public decimal? ISR
    {
        get;
        set;
    }

    public decimal? ISRRate
    {
        get;
        set;
    }

    public decimal? Total
    {
        get;
        set;
    }

    public bool? BaseCurrency
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public decimal? OriginalCurrencyDiscountAmount
    {
        get;
        set;
    }

    public decimal? OriginalCurrencySubtotal
    {
        get;
        set;
    }

    public bool? IsPercentage
    {
        get;
        set;
    }

    public int? ExternalIDType
    {
        get;
        set;
    }

    public decimal? VatRet
    {
        get;
        set;
    }

    public IEnumerable<string>? ContactEmails
    {
        get;
    }

    public IEnumerable<QuoteItem>? Items
    {
        get;
    }
}
