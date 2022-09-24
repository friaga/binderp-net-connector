namespace BindERP.Connector.Common;

/// <summary>
/// Representa un servicio base de los clientes de Bind.
/// </summary>
internal abstract class BaseService : IDisposable
{
    /// <summary>
    /// Representa un valor que indica si el servicio ha sido liberado correctamente o no.
    /// </summary>
    private bool disposed;

    private readonly IBindConnection connection;

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="BaseService"/>.
    /// </summary>
    /// <param name="connection">El cliente tipificado inicializado en el setup.</param>
    /// <exception cref="ArgumentNullException">Lanzada cuando el cliente no ha sido inicializado correctamente.</exception>
    public BaseService(IBindConnection connection)
    {
        this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
    }

    /// <summary>
    /// Obtiene el cliente de conexión con el API.
    /// </summary>
    protected HttpClient HttpClient
    {
        get
        {
            return this.connection.GetClient();
        }
    }

    /// <summary>
    /// Libera los recursos utilizados por el servicio.
    /// </summary>
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Realiza la liberación de los recursos del servicio si y solo si se deben de liberar.
    /// </summary>
    /// <param name="disposing">Un valor que indica si se deben liberar los recursos o no.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                if (this.connection is not null)
                {
                    this.connection.Dispose();
                }
            }

            this.disposed = true;
        }
    }
}
