namespace BindERP.Connector.Modules.Sales.Records;

/// <summary>
/// Representa un registro de la página de clientes.
/// </summary>
public record CustomerRecord
{
    /// <summary>
    /// Obtiene o establece el identificador del cliente.
    /// </summary>
    public Guid ID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el número de cliente.
    /// </summary>
    public long? Number
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene el nombre del cliente.
    /// </summary>
    public string? ClientName
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre de la persona fisica o moral.
    /// </summary>
    public string? LegalName
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el RFC del cliente.
    /// </summary>
    public string? RFC
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el correo electrónico predeterminado del cliente.
    /// </summary>
    public string? Email
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el telefono predterminado del cliente.
    /// </summary>
    public string? Phone
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la siguiente fecha de contacto.
    /// </summary>
    public DateTime? NextContactDate
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la ubicación.
    /// </summary>
    public Guid? LocationID
    {
        get;
        set;
    }
}
