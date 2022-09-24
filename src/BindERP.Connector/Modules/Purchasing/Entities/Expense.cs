using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Purchasing.Entities;

public record Expense
{
    public Expense()
    {
        this.Items = new List<ExpenseItem>();
    }
    public Guid? ID { get; set; }
    public Guid? ProviderID { get; set; }
    public string? ProviderName { get; set; }
    public string? Status { get; set; }
    public int? StatusCode { get; set; }
    public DateTime? CreationDate { get; set; }
    public int? CreditDays { get; set; }
    public Guid? LocationID { get; set; }
    public Guid? ClientID { get; set; }
    public Guid? DepartmentID { get; set; }
    public int? DocumentType { get; set; }
    public string? DocumentNumber { get; set; }
    public string? Comments { get; set; }
    public decimal? VAT { get; set; }
    public Guid? InvoiceID { get; set; }
    public Guid? CurrencyID { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? UUID { get; set; }
    public string? Series { get; set; }
    public decimal? VATRetention { get; set; }
    public decimal? ISRRetention { get; set; }
    public decimal? IEPS { get; set; }
    public decimal? Discount { get; set; }
    public Guid? FiscalID { get; set; }
    public int? ISRRetType { get; set; }
    public string? RFC { get; set; }
    public string? DocumentTypeText { get; set; }
    public string? CurrencyName { get; set; }
    public string? ClientName { get; set; }
    public string? LocationName { get; set; }


    [JsonProperty("ExpensePurchaseOrderItems")]
    public IEnumerable<ExpenseItem> Items
    {
        get;
    }
}
