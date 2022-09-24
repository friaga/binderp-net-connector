using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Contracts;

/// <summary>
/// Representa la interfase del servicio de categorias.
/// </summary>
public interface ICategoriesService
{
    /// <summary>
    /// Obtiene las categorias del sistema.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>Las categorias del sistema.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<IEnumerable<Category>?> GetCategoriesAsync(CancellationToken cancellationToken = default);
}
