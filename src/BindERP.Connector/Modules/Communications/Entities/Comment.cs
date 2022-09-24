namespace BindERP.Connector.Modules.Communications.Entities;

/// <summary>
/// 
/// </summary>
public record Comment
{
    public Guid ID
    {
        get;
        set;
    }

    public Guid? ExternalID
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public string? EmployeeName
    {
        get;
        set;
    }
}
