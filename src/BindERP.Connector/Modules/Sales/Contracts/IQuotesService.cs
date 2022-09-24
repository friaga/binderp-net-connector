using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindERP.Connector.Common;
using BindERP.Connector.Modules.Sales.Entities;
using BindERP.Connector.Modules.Sales.Records;

namespace BindERP.Connector.Modules.Sales.Contracts;

public interface IQuotesService
{

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<QuoteRecord>?> GetQuotesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="quoteID">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Quote?> GetQuoteAsync(Guid quoteID, CancellationToken cancellationToken = default);



    //Task<Guid?> CreateQuoteAsync(object quote, CancellationToken cancellationToken = default);

    //Task<Guid?> EditQuoteAsync(object quote, CancellationToken cancellationToken = default);

    //Task<bool> DeleteQuoteAsync(Guid quoteID, CancellationToken cancellationToken = default);
}
