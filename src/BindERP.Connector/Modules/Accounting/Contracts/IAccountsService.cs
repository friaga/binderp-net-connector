using BindERP.Connector.Common;
using BindERP.Connector.Modules.Accounting.Entities;

namespace BindERP.Connector.Modules.Accounting.Contracts;

/// <summary>
/// 
/// </summary>
public interface IAccountsService
{
    /// <summary>
    /// Obtiene una página de cuentas contables.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de cuentas contables.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<Account>?> GetAccountsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    //Task<Guid?> CreateAccountAsync(object account, CancellationToken cancellationToken = default);
    
    //Task<bool?> DeleteAccountAsync(Guid accountID, Guid? replacementID = null, CancellationToken cancellationToken = default);
}
