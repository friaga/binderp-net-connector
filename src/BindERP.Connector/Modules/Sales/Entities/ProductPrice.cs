namespace BindERP.Connector.Modules.Sales.Entities;

public record ProductPrice
{
    public ProductPrice()
    {
        this.Items = new List<ProductPriceItem>();
    }

    public IEnumerable<ProductPriceItem> Items
    {
        get;
    }
}
