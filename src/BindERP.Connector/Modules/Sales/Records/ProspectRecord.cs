namespace BindERP.Connector.Modules.Sales.Records;

public record ProspectRecord
{
    public string? CompanyName
    {
        get;
        set;
    }

    public string? ProspectName
    {
        get;
        set;
    }

    public string? Email
    {
        get;
        set;
    }

    public string? Phone
    {
        get;
        set;
    }

    public Guid? ID
    {
        get;
        set;
    }

    public string? SalesMan
    {
        get;
        set;
    }
}
