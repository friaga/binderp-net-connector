namespace BindERP.Connector.Modules.Communications.Entities;

public record Activity
{
    public Guid? ID
    {
        get;
        set;
    }

    public string? Title
    {
        get;
        set;
    }
    public DateTime Start
    {
        get;
        set;
    }
    public DateTime End
    {
        get;
        set;
    }
    public Guid? EmployeeID
    {
        get;
        set;
    }
    public bool Done
    {
        get;
        set;
    }
    public int Status
    {
        get;
        set;
    }
    public Guid? GroupID
    {
        get;
        set;
    }
    public int? Type
    {
        get;
        set;
    }

    public Guid? ExternalID
    {
        get;
        set;
    }
    public bool AllDay
    {
        get;
        set;
    }
    public Guid? LocationID
    {
        get;
        set;
    }
    public bool? IsPublic
    {
        get;
        set;
    }
    public Guid? EventTypeID
    {
        get;
        set;
    }

    public string? EventTypeText
    {
        get;
        set;
    }
    public long? ExternalIDType
    {
        get;
        set;
    }
    public string? ActionName
    {
        get;
        set;
    }
    public string? ActionLink
    {
        get;
        set;
    }
    public string? Description
    {
        get;
        set;
    }
}
