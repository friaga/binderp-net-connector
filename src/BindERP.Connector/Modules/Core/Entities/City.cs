namespace BindERP.Connector.Modules.Core.Entities;

/// <summary>
/// Representa una ciudad.
/// </summary>
public record City
{
    /// <summary>
    /// Obtiene o establece el identificador de la ciudad.
    /// </summary>
    public Guid ID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre de la ciudad.
    /// </summary>
    public string? Name
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la entidad federativa.
    /// </summary>
    public Guid StateID
    {
        get;
        set;
    }
}
