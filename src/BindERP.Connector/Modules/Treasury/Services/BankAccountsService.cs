using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Treasury.Contracts;
using BindERP.Connector.Modules.Treasury.Entities;

namespace BindERP.Connector.Modules.Treasury.Services;

/// <summary>
/// Representa el servicio de las cuentas de banco.
/// </summary>
internal class BankAccountsService : BaseService, IBankAccountsService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="BankAccountsService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public BankAccountsService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de las cuentas de banco.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de las cuentas de banco.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<BankAccount>?> GetBankAccountsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<BankAccount>>($"/api/BankAccounts", criteria, cancellationToken);
    }
}
