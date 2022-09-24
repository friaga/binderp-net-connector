using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Core.Entities;

public record Company
{
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
    
    public string? LegalName
    { 
        get; 
        set; 
    }
    
    public DateTime? InvoiceCertExpiration
    { 
        get; 
        set; 
    }
    
    public string? IMSSID
    { 
        get; 
        set; 
    }
    
    public string? FiscalType
    { 
        get; 
        set; 
    }

    public string? CommercialName
    { 
        get; 
        set; 
    }

    public string? RFC
    { 
        get; 
        set; 
    }

    public string? PhoneNumbers
    { 
        get; 
        set; 
    }

    public string? EntityType
    {
        get;
        set;
    }

}
