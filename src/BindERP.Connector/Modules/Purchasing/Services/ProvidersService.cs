using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Purchasing.Contracts;
using BindERP.Connector.Modules.Purchasing.Entities;

namespace BindERP.Connector.Modules.Purchasing.Services;

internal class ProvidersService : BaseService, IProvidersService
{
    public ProvidersService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de proveedores.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de proveedores.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<Provider>?> GetProvidersPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<Provider>>($"/api/Providers", criteria, cancellationToken);
    }
}
