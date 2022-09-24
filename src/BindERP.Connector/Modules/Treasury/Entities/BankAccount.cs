namespace BindERP.Connector.Modules.Treasury.Entities;

/// <summary>
/// Representa una cuenta bancaria.
/// </summary>
public record BankAccount
{
    /// <summary>
    /// Obtiene o establece el identificador de la cuenta bancaria.
    /// </summary>
    public Guid ID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el tipo.
    /// </summary>
    public int Type
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece la descripción del tipo.
    /// </summary>
    public string? TypeText
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador del banco.
    /// </summary>
    public Guid? BankID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre del banco.
    /// </summary>
    public string? BankName
    {
        get;
        set;
    }

    public string? Name
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el saldo de la cuenta.
    /// </summary>
    public decimal Balance
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la moneda.
    /// </summary>
    public Guid CurrencyID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el código de la moneda.
    /// </summary>
    public string? CurrencyCode
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la sucursal.
    /// </summary>
    public Guid? LocationID
    {
        get;
        set;
    }
}
