namespace BindERP.Connector.Modules.Accounting.Entities;

public record AccountSubGroup
{
    public AccountSubGroup()
    {
        this.SubGroups = new List<AccountSubGroup>();
    }

    public Guid ID
    {
        get;
        set;
    }

    public string? Code
    {
        get;
        set;
    }

    public string? Prefix
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }


    public IEnumerable<AccountSubGroup> SubGroups
    {
        get;
    }


}
