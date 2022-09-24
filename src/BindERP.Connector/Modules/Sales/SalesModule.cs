using BindERP.Connector.Modules.Sales.Contracts;

namespace BindERP.Connector.Modules.Sales;

internal class SalesModule : ISalesModule
{
    public SalesModule(ICustomersService customers, IFormulasService formulas, IInvoicesService invoices, IProductsService products, IProspectsService prospects, IQuotesService quotes, ISalesOrdersService orders, IServicesService services)
    {
        this.CustomersService   = customers;
        this.FormulasService    = formulas;
        this.InvoicesService    = invoices;
        this.ProductsService    = products;
        this.ProspectsService   = prospects;
        this.QuotesService      = quotes;
        this.SalesOrdersService = orders;
        this.ServicesService    = services;
    }

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
