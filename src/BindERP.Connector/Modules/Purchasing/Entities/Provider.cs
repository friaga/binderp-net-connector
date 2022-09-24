namespace BindERP.Connector.Modules.Purchasing.Entities;

public record Provider
{
    public Guid? ID
    {
        get;
        set;
    }

    public long? Number
    {
        get;
        set;
    }

    public string? ProviderName
    {
        get;
        set;
    }
    public string? LegalName
    {
        get;
        set;
    }

    public string? RFC
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

    public string? City
    {
        get;
        set;
    }
}
