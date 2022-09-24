namespace BindERP.Connector.Modules.Core.Entities;

public record Profile
{
    public Profile()
    {
        this.Roles     = new List<string>();
        this.Locations = new List<Guid>();
    }

    public Guid CompanyID
    {
        get;
        set;
    }

    public string? CompanyName
    {
        get;
        set;
    }

    public long? CompanyNumber
    {
        get;
        set;
    }

    public string? Email
    {
        get;
        set;
    }

    public string? Name
    {
        get;
        set;
    }

    public string? RFC
    {
        get;
        set;
    }

    public IEnumerable<string>? Roles
    {
        get;
        set;
    }

    public Guid? UserID
    {
        get;
        set;
    }

    public string? Username
    {
        get;
        set;
    }

    public IEnumerable<Guid>? Locations
    {
        get;
    }
}
