namespace BindERP.Connector.Modules.Core.Entities;

public record Series
{
    public Series()
    {
        this.Locations = new List<Guid>();
    }

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

    public long StartNumber
    {
        get;
        set;
    }

    public long CurrentNumber
    {
        get;
        set;
    }

    public DateTime Date
    {
        get;
        set;
    }

    public int? DocType
    {
        get;
        set;
    }

    public string? DocTypeText
    {
        get;
        set;
    }

    public IEnumerable<Guid>? Locations
    {
        get;
    }
}
