namespace BindERP.Connector.Modules.Core.Entities;

public record SubCategory
{
    public SubCategory()
    {
        this.SubCategories = new List<SubCategory>();
    }

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

    public IEnumerable<SubCategory> SubCategories
    {
        get;
    }
}
