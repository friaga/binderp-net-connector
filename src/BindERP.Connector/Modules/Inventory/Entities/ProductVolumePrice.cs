namespace BindERP.Connector.Modules.Inventory.Entities;

public record ProductVolumePrice
{
    public long? Min
    {
        get;
        set;
    }

    public long? Max
    {
        get;
        set;
    }

    public long? Value
    {
        get;
        set;
    }

    public long? Type
    {
        get;
        set;
    }
}
