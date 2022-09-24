namespace BindERP.Connector;

public interface IBindConnection : IDisposable
{
    public HttpClient GetClient();
}
