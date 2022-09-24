using BindERP.Connector.Common;
using BindERP.Connector.Modules.Communications.Entities;

namespace BindERP.Connector.Modules.Communications.Contracts;

/// <summary>
/// Representa la interfase del servicio de comentarios.
/// </summary>
public interface ICommentsService
{
    /// <summary>
    /// Obtiene una página de comentarios.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de comentarios.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Page<Comment>?> GetCommentsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default);


    //Task<bool?> CreateCommentAsync(object comment, CancellationToken cancellationToken = default);
}
