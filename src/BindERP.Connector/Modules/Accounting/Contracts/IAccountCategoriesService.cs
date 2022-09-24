using BindERP.Connector.Modules.Accounting.Entities;

namespace BindERP.Connector.Modules.Accounting.Contracts;

/// <summary>
/// 
/// </summary>
public interface IAccountCategoriesService
{
    /// <summary>
    /// Obtiene las categorías de cuentas contables.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>Las categorías de cuentas contables.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<AccountCategory?> GetAccountCategoriesAsync(CancellationToken cancellationToken = default);
}
