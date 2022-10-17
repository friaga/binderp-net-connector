namespace BindERP.Connector;

public interface IBindConnection : IDisposable
{
    public void SetEndpointUri(string endpointUri);

    public void SetEndpointUri(Uri endpointUri);

    public void SetEndpointKey(string endpointKey);

    public void SetSubscriptionKey(string subscriptionKey);

    public HttpClient GetClient();
}
