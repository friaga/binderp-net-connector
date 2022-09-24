namespace BindERP.Connector.Modules.Core.Entities;

/// <summary>
/// Representa un banco.
/// </summary>
public record Bank
{
    /// <summary>
    /// Obtiene o establece el identificador del banco.
    /// </summary>
    public Guid ID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre del banco.
    /// </summary>
    public string? Name
    {
        get;
        set;
    }
}
