using System.Text;
using BindERP.Connector.Common;
using BindERP.Connector.Exceptions;
using BindERP.Connector.Extensions;
using BindERP.Connector.Modules.Webhooks.Contracts;
using BindERP.Connector.Modules.Webhooks.Entities;
using BindERP.Connector.Modules.Webhooks.Models;
using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Webhooks.Services;

/// <summary>
/// Representa el servicio de subscripciones.
/// </summary>
public class SubscriptionsService : BaseService, ISubscriptionsService
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="AccountingJournalsService"/>.
    /// </summary>
    /// <param name="connection">El cliente que realiza las peticiones directamente al API de BIND ERP.</param>
    public SubscriptionsService(IBindConnection connection) 
        : base(connection)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="criteria"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<Page<Subscription>?> GetSubscriptionsPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<Subscription>>($"/api/WebHookSubscriptions", criteria, cancellationToken);
    }

    /// <summary>
    /// Obtiene una página de Webhooks disponibles.
    /// </summary>
    /// <param name="criteria">Los criterios de búsqueda.</param>
    /// <param name="cancellationToken">El token de cancelación.</param>
    /// <returns>La página de Webhooks disponibles.</returns>
    /// <exception cref="InvalidOperationException">Lanzada cuando ha ocurrido un error en el procesamiento local de la operación.</exception>
    /// <exception cref="HttpRequestException">Lanzada cuando ha ocurrido un error en el envio de la operación.</exception>
    /// <exception cref="TaskCanceledException">Lanzada cuando la operación es cancelada.</exception>
    public Task<Page<WebHook>?> GetWebHooksPageAsync(SearchCriteria? criteria = null, CancellationToken cancellationToken = default)
    {
        return this.HttpClient.GetAsync<Page<WebHook>>($"/api/WebHooks", criteria, cancellationToken);
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> CreateSubscriptionAsync(SubscriptionCreationModel model, CancellationToken cancellationToken = default)
    {
        _ = model ?? throw new ArgumentNullException(nameof(model));
        _ = model.EventName ?? throw new ArgumentNullException(nameof(model));
        _ = model.TargetUrl ?? throw new ArgumentNullException(nameof(model));

        var json = JsonConvert.SerializeObject(model) ?? throw new UnableToSerializeException();

        using var content  = new StringContent(json, Encoding.UTF8, "application/json");
        using var response = await this.HttpClient.PostAsync("/api/WebHookSubscriptions ", content, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> EditSubscriptionAsync(SubscriptionEditionModel model, CancellationToken cancellationToken = default)
    {
        _ = model ?? throw new ArgumentNullException(nameof(model));
        _ = model.EventName ?? throw new ArgumentNullException(nameof(model));
        _ = model.TargetUrl ?? throw new ArgumentNullException(nameof(model));

        var json = JsonConvert.SerializeObject(model) ?? throw new UnableToSerializeException();

        using var content  = new StringContent(json, Encoding.UTF8, "application/json");
        using var response = await this.HttpClient.PutAsync("/api/WebHookSubscriptions", content, cancellationToken);
        
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> DeleteSubscriptionAsync(SubscriptionDeletionModel model, CancellationToken cancellationToken = default)
    {
        _ = model.ID ?? throw new ArgumentNullException(nameof(model));

        var deletion = $"/api/WebHookSubscriptions?id={model.ID}";
        if (model.SubscriptionID is not null && model.SubscriptionID.Value != Guid.Empty)
        {
            deletion += $"&subscriptionID={model.SubscriptionID}";
        }

        var endpoint = new Uri(deletion, UriKind.Relative);
        using var response = await this.HttpClient.DeleteAsync(endpoint, cancellationToken);
        
        return response.IsSuccessStatusCode;
    }
}
