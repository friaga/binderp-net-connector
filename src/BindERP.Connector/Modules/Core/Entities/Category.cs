namespace BindERP.Connector.Modules.Core.Entities;

/// <summary>
/// Representa una categoría de conceptos.
/// </summary>
public record Category
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="Category"/>.
    /// </summary>
    public Category()
    {
        this.SubCategories = new List<SubCategory>();
    }

    /// <summary>
    /// Obtiene o establece el identificador de la categoría.
    /// </summary>
    public Guid ID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre de la categoría.
    /// </summary>
    public string? Name
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene las subcategorias de la categoría actual.
    /// </summary>
    public IEnumerable<SubCategory> SubCategories
    {
        get;
    }
}
