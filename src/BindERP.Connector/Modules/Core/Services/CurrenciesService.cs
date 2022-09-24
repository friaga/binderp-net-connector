using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Core.Contracts;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Services;

/// <summary>
/// Representa el servicio de los tipos de cambio.
/// </summary>
internal class CurrenciesService : BaseService, ICurrenciesService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="CurrenciesService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public CurrenciesService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de tipos de cambio.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de tipos de cambio.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<Currency>?> GetCurrenciesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<Currency>>($"/api/Currencies", criteria, cancellationToken);
    }
}
