using BindERP.Connector.Modules.Sales.Contracts;

namespace BindERP.Connector.Modules.Sales;

public interface ISalesModule
{
    public ICustomersService CustomersService
    {
        get;
    }

    public IFormulasService FormulasService
    {
        get;
    }

    public IInvoicesService InvoicesService
    {
        get;
    }

    public IProductsService ProductsService
    {
        get;
    }

    public IProspectsService ProspectsService
    {
        get;
    }

    public IQuotesService QuotesService
    {
        get;
    }

    public ISalesOrdersService SalesOrdersService
    {
        get;
    }

    public IServicesService ServicesService
    {
        get;
    }
}
