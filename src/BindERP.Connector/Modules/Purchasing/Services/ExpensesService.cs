using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Purchasing.Contracts;
using BindERP.Connector.Modules.Purchasing.Entities;

namespace BindERP.Connector.Modules.Purchasing.Services;

internal class ExpensesService : BaseService, IExpensesService
{
    public ExpensesService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene el detalle un gasto.
    /// </summary>
    /// <param name="expenseID">El identificador del gasto.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>El detalle de un gasto.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Expense?> GetExpenseAsync(Guid expenseID, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Expense>($"/api/Expenses/{expenseID}", cancellationToken);
    }

    /// <summary>
    /// Obtiene una página de pagos de un gasto.
    /// </summary>
    /// <param name="expenseID">El identificador del gasto.</param>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de pagos de un gasto.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<ExpensePayment>?> GetExpensePaymentsAsync(Guid expenseID, SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<ExpensePayment>>($"/api/Expenses/Payment/{expenseID}", criteria, cancellationToken);
    }
}
