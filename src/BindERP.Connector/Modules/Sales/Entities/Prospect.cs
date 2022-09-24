namespace BindERP.Connector.Modules.Sales.Entities;

public record Prospect
{
    public string? Comments
    {
        get;
        set;
    }

    public string? Company
    {
        get;
        set;
    }


    public DateTime? CreationDate
    {
        get;
        set;
    }


    public string? Email
    {
        get;
        set;
    }


    public Guid? EmployeeID
    {
        get;
        set;
    }


    public Guid? ID
    {
        get;
        set;
    }

    public bool? IsPublic
    {
        get;
        set;
    }


    public string? Name
    {
        get;
        set;
    }

    public string? Phone
    {
        get;
        set;
    }

    public string? PhoneExt
    {
        get;
        set;
    }
}
