namespace BindERP.Connector.Modules.Core.Entities;

public record User
{
    public Guid ID
    {
        get;
        set;
    }

    public string? FullName
    {
        get;
        set;
    }

    public string? JobPosition
    {
        get;
        set;
    }

    public Guid? LocationID
    {
        get;
        set;
    }

    public string? Email
    {
        get;
        set;
    }

    public string? UserName
    {
        get;
        set;
    }
}
