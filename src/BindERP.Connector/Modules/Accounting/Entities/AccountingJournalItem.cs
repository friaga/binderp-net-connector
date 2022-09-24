namespace BindERP.Connector.Modules.Accounting.Entities;

public record AccountingJournalItem
{
    public Guid AccountID
    {
        get;
        set;
    }
    public string? AccountName
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public decimal Debit
    {
        get;
        set;
    }
    public decimal Charge
    {
        get;
        set;
    }
}
