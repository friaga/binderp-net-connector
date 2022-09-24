namespace BindERP.Connector.Modules.Inventory.Entities;

public record ProductLotImport
{
    public Guid? ID
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }

    public decimal? Qty
    {
        get;
        set;
    }
}
