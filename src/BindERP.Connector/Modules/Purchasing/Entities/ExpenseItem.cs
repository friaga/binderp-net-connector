namespace BindERP.Connector.Modules.Purchasing.Entities;

public record ExpenseItem
{
    public Guid? ID { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Cost { get; set; }
    public Guid? TypeID { get; set; }
    public string? Name { get; set; }
    public Guid? ExpensePurchaseOrderID { get; set; }
    public long? IndexItem { get; set; }
    public Guid? SATCompanyAccountID { get; set; }
}
