using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Sales.Contracts;
using BindERP.Connector.Modules.Sales.Entities;
using BindERP.Connector.Modules.Sales.Records;

namespace BindERP.Connector.Modules.Sales.Services;

internal class CustomersService : BaseService, ICustomersService
{
    public CustomersService(IBindConnection connection)
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene el detalle de un cliente.
    /// </summary>
    /// <param name="customerID">El identificador del cliente.</param>
    /// <param name="cancellationToken">El token de cancelacion.</param>
    /// <returns>El detalle del cliente.</returns>
    /// <exception cref="ArgumentException">Lanzada cuando el identificador del cliente es invalido.</exception>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operacion.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operacion.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operacion es cancelada.</exception>
    public Task<Customer?> GetCustomerAsync(Guid customerID, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Customer>($"/api/Clients/{customerID}", cancellationToken);
    }

    public Task<Page<CustomerRecord>?> GetCustomersPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<CustomerRecord>>($"/api/Clients", criteria, cancellationToken);
    }
}
