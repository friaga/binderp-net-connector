using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Core.Entities;

public record Location
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

    public string? Street
    {
        get;
        set;
    }

    public string? ExtNumber
    {
        get;
        set;
    }

    public string? IntNumber
    {
        get;
        set;
    }

    public string? ZipCode
    {
        get;
        set;
    }

    [JsonProperty("Colonia")]
    public string? Block
    {
        get;
        set;
    }

    public string? City
    {
        get;
        set;
    }

    public string? State
    {
        get;
        set;
    }
}
