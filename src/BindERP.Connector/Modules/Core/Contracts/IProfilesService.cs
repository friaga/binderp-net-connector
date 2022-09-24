using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Contracts;

/// <summary>
/// Representa la interfase del servicio de perfiles.
/// </summary>
public interface IProfilesService
{
    /// <summary>
    /// Obtiene el perfil del usuario.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>El perfil del usuario.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Profile?> GetUserProfileAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene el perfil de la empresa.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>El perfil de la empresa.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    Task<Company?> GetCompanyProfileAsync(CancellationToken cancellationToken = default);
}
