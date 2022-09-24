using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Accounting.Contracts;
using BindERP.Connector.Modules.Accounting.Entities;

namespace BindERP.Connector.Modules.Accounting.Services;

/// <summary>
/// Representa el servicio de las categorias de cuentas contables.
/// </summary>
public class AccountCategoriesService : BaseService, IAccountCategoriesService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="AccountsService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public AccountCategoriesService(IBindConnection connection)
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene las categorías de cuentas contables.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>Las categorías de cuentas contables.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<AccountCategory?> GetAccountCategoriesAsync(CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<AccountCategory>($"/api/accountcategories", cancellationToken);
    }
}
