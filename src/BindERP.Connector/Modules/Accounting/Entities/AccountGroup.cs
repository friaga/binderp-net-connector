namespace BindERP.Connector.Modules.Accounting.Entities;

public record AccountGroup
{
    public AccountGroup()
    {
        this.Groups = new List<AccountSubGroup>();
    }

    public Guid ID
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    
    public IEnumerable<AccountSubGroup> Groups
    {
        get;
    }
}
