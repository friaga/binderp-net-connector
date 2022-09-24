using BindERP.Connector.Common;
using BindERP.Connector.Modules.Accounting.Entities;

namespace BindERP.Connector.Modules.Accounting.Contracts;

/// <summary>
/// 
/// </summary>
public interface IJournalsService
{
    /// <summary>
    /// Obtiene una página de pólizas contables.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de pólizas contables.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<AccountingJournal>?> GetJournalsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);



    //Task<Guid?> CreateJournalAsync(object jornal, CancellationToken cancellationToken = default);

    //Task<Guid?> EditJournalAsync(object jornal, CancellationToken cancellationToken = default);

    //Task<bool?> DeleteJournalAsync(List<Guid> identifiers, CancellationToken cancellationToken = default);
}
