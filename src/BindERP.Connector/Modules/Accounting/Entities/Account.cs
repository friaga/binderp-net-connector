namespace BindERP.Connector.Modules.Accounting.Entities;

public record Account
{
    public Guid ID
    {
        get;
        set;
    }


    public string? Number
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public Guid? GLGroupID
    {
        get;
        set;
    }

    public string? GLGroup
    {
        get;
        set;
    }

    public Guid? GroupID
    {
        get;
        set;
    }

    public string? Group
    {
        get;
        set;
    }

    public Guid? SubGroupID
    {
        get;
        set;
    }

    public string? SubGroup
    {
        get;
        set;
    }


}
