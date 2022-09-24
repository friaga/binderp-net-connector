using BindERP.Connector.Common;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Core.Contracts;
using BindERP.Connector.Modules.Core.Entities;

namespace BindERP.Connector.Modules.Core.Services;

/// <summary>
/// Representa el servicio de los perfiles.
/// </summary>
internal class ProfilesService : BaseService, IProfilesService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="ProfilesService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public ProfilesService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// Obtiene el perfil del usuario.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>El perfil del usuario.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Profile?> GetUserProfileAsync(CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Profile>("/api/UserProfile", cancellationToken);
    }

    /// <summary>
    /// Obtiene el perfil de la empresa.
    /// </summary>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>El perfil de la empresa.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Company?> GetCompanyProfileAsync(CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Company>("/api/CompanyProfile", cancellationToken);
    }
}
