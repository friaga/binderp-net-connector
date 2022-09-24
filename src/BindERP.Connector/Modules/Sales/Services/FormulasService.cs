using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Sales.Contracts;
using BindERP.Connector.Modules.Sales.Entities;
using BindERP.Connector.Modules.Sales.Records;

namespace BindERP.Connector.Modules.Sales.Services;

internal class FormulasService : BaseService, IFormulasService
{
    public FormulasService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<FormulaRecord>?> GetFormulasPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<FormulaRecord>>($"/api/Formulas", criteria, cancellationToken);
    }

    /// <summary>
    /// Obtiene una página de conceptos de venta (servicios).
    /// </summary>
    /// <param name="formulaID">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de conceptos de venta (servicios).</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Formula?> GetFormulaAsync(Guid formulaID, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Formula>($"/api/Formulas/{formulaID}", cancellationToken);
    }
}
