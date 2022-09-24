using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Accounting.Contracts;
using BindERP.Connector.Modules.Accounting.Entities;

namespace BindERP.Connector.Modules.Accounting.Services;

/// <summary>
/// Representa el servicio de las pólizas contables.
/// </summary>
internal class JournalsService : BaseService, IJournalsService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="JournalsService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public JournalsService(IBindConnection connection)
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de pólizas contables.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de pólizas contables.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<AccountingJournal>?> GetJournalsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<AccountingJournal>>($"/api/AccountingJournals", criteria, cancellationToken);
    }
}
