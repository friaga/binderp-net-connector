namespace BindERP.Connector.Modules.Accounting.Entities;

public record AccountingJournal
{
    public AccountingJournal()
    {
        this.Items = new List<AccountingJournalItem>();
    }

    public Guid ID
    {
        get;
        set;
    }

    public Guid DocumentID
    {
        get;
        set;
    }

    public string? Type
    {
        get;
        set;
    }

    public DateTime? ApplicationDate
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public long? Number
    {
        get;
        set;
    }

    public Guid? LocationID
    {
        get;
        set;
    }

    public string? PeriodType
    {
        get;
        set;
    }

    public IEnumerable<AccountingJournalItem> Items
    {
        get;
    }
}
