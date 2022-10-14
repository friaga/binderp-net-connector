namespace BindERP.Connector.Modules.Inventory.Entities;

public record WarehouseReception
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

    public string? DocNumber
    {
        get;
        set;
    }

    public Guid? ProviderID
    {
        get;
        set;
    }

    public string? ProviderName
    {
        get;
        set;
    }

    public Guid? WarehouseID
    {
        get;
        set;
    }

    public string? WarehouseName
    {
        get;
        set;
    }

    public DateTime? ReceptionDate
    {
        get;
        set;
    }

    public DateTime? DocumentDate
    {
        get;
        set;
    }

    public int? TypeID
    {
        get;
        set;
    }

    public int? StatusID
    {
        get;
        set;
    }

    public bool? IsDeletable
    {
        get;
        set;
    }

    public bool? BaseCurrency
    {
        get;
        set;
    }

    public string? TypeName
    {
        get;
        set;
    }

    public string? StatusName
    {
        get;
        set;
    }
}
