using BindERP.Connector.Common;
using BindERP.Connector.Modules.Sales.Entities;
using BindERP.Connector.Modules.Sales.Records;

namespace BindERP.Connector.Modules.Sales.Contracts;

public interface IInvoicesService
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
    Task<Page<InvoiceRecord>?> GetInvoicesPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="invoiceID"></param>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<InvoicePayment>?> GetInvoicePaymentsPageAsync(Guid invoiceID, SearchCriteria? criteria = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="identifier">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Invoice?> GetInvoiceAsync(string identifier, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="identifier">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<string?> GetInvoiceFiscalReceiptAsync(Guid identifier, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="identifier">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<byte[]?> GetInvoiceDigitalReceiptAsync(Guid identifier, CancellationToken cancellationToken = default);




    //Task<Guid?> CreateCreditNoteAsync(object creditNote, CancellationToken cancellationToken = default);

    //Task<Guid?> CreateInvoiceAsync(object invoice, CancellationToken cancellationToken = default);

    //Task<bool> DeleteInvoiceAsync(string identifier, CancellationToken cancellationToken = default);


    //Task<bool> CreatePaymentAsync(object payment, CancellationToken cancellationToken = default);
}
