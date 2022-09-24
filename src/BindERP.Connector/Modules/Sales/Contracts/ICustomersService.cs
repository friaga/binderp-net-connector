using BindERP.Connector.Common;
using BindERP.Connector.Modules.Sales.Entities;
using BindERP.Connector.Modules.Sales.Records;

namespace BindERP.Connector.Modules.Sales.Contracts;

public interface ICustomersService
{
    /////// <summary>
    /////// Agregar Cliente
    /////// </summary>
    /////// <remarks>
    /////// 
    /////// </remarks>
    /////// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /////// <param name="newClient"></param>
    /////// <returns>Task of Guid?</returns>
    ////Task<Guid?> CreateCustomerAsync(object customer, CancellationToken cancellationToken = default);

    /////// <summary>
    /////// Borrar Cliente
    /////// </summary>
    /////// <remarks>
    /////// 
    /////// </remarks>
    /////// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /////// <param name="id"></param>
    /////// <returns>Task of void</returns>
    ////Task<bool> DeleteCustomerAsync(Guid? identifier, CancellationToken cancellationToken = default);

    /////// <summary>
    /////// Editar Cliente
    /////// </summary>
    /////// <remarks>
    /////// 
    /////// </remarks>
    /////// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
    /////// <param name="_client"></param>
    /////// <returns>Task of void</returns>
    ////Task<bool> EditCustomerAsync(object customer, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="criteria"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Page<CustomerRecord>?> GetCustomersPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene el detalle de un cliente.
    /// </summary>
    /// <param name="cistomerID">El identificador del cliente.</param>
    /// <param name="cancellationToken">El token de cancelacion.</param>
    /// <returns>El detalle del cliente.</returns>
    /// <exception cref="ArgumentException">Lanzada cuando el identificador del cliente es invalido.</exception>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operacion.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operacion.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operacion es cancelada.</exception>
    Task<Customer?> GetCustomerAsync(Guid customerID, CancellationToken cancellationToken = default);
}
