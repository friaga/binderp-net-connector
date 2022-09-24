namespace BindERP.Connector.Modules.Purchasing.Entities;

public record ExpensePayment
{
    public Guid? AccountMovementID { get; set; }
    public long? AccountMovementNumber { get; set; }
    public DateTime? ApplicationDate { get; set; }
    public string? Comments { get; set; }
    public string? Employee { get; set; }
    public decimal? ExchangeRate { get; set; }
    public Guid? ExternalID { get; set; }
    public bool? HasCancellationXML { get; set; }
    public Guid? ID { get; set; }
    public int? StatusCode { get; set; }
    public string? Account { get; set; }
    public decimal? Amount { get; set; }
    public bool? HasAccountingOperation { get; set; }
    public string? StatusText { get; set; }
}
