namespace BindERP.Connector.Modules.Core.Entities;

public record Currency
{
    public Guid ID
    {
        get;
        set;
    }

    public string? Name
    {
        get;
        set;
    }

    public string? Code
    {
        get;
        set;
    }

    public double? ExchangeRate
    {
        get;
        set;
    }
}
