using BindERP.Connector.Common;
using BindERP.Connector.Modules.Treasury.Entities;

namespace BindERP.Connector.Modules.Treasury.Contracts
{
    /// <summary>
    /// Representa la interfase del servicio de cuentas de banco.
    /// </summary>
    public interface IBankAccountsService
    {
        /// <summary>
        /// Obtiene una página de las cuentas de banco.
        /// </summary>
        /// <param name="criteria">Los criterios de búsqueda.</param>
        /// <param name="cancellationToken">El token de cancelación.</param>
        /// <returns>La página de las cuentas de banco.</returns>
        /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
        /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
        /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
        Task<Page<BankAccount>?> GetBankAccountsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);



        //Task<Guid?> CreateAdjustmentAsync(object adjustment, CancellationToken cancellationToken = default);
    }
}
