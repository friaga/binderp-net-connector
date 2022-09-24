using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Sales.Entities;

/// <summary>
/// Representa un registro de un cliente.
/// </summary>
public record Customer
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
    /// Obtiene o establece el RFC.
    /// </summary>
    public string? RFC
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre de persona fisica o moral.
    /// </summary>
    public string? LegalName
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre comercial.
    /// </summary>
    public string? CommercialName
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece los dias de credito.
    /// </summary>
    public int? CreditDays
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el monto del credito.
    /// </summary>
    public double? CreditAmount
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el metodo de pago.
    /// </summary>
    public string? PaymentMethod
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece la fecha de creacion.
    /// </summary>
    public DateTime CreationDate
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el estado.
    /// </summary>
    public string? Status
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el contacto de ventas.
    /// </summary>
    public string? SalesContact
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el contacto de creditos.
    /// </summary>
    public string? CreditContact
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece la sucursal.
    /// </summary>
    [JsonProperty("Loctaion")]
    public string? Location
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la sucursal.
    /// </summary>
    [JsonProperty("LoctaionID")]
    public Guid? LocationID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece los comentarios.
    /// </summary>
    public string? Comments
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el nombre de la lista de precios.
    /// </summary>
    public string? PriceList
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el identificador de la lista de precios.
    /// </summary>
    public Guid? PriceListID
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el tipo de condiciones de pago.
    /// </summary>
    public string? PaymentTermType
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el correo electronico.
    /// </summary>
    public string? Email
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece los telefonos.
    /// </summary>
    public string? Telephones
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el numero de cliente.
    /// </summary>
    public long Number
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el numero de cuenta.
    /// </summary>
    public string? AccountNumber
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el descuento predeterminado.
    /// </summary>
    public double? DefaultDiscount
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el origen del cliente.
    /// </summary>
    public string? ClientSource
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece la cuenta.
    /// </summary>
    public string? Account
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece la ciudad.
    /// </summary>
    public string? City
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece el estado.
    /// </summary>
    public string? State
    {
        get;
        set;
    }

    /// <summary>
    /// Obtiene o establece la lista de identificadores de direcciones. 
    /// </summary>
    public List<Guid>? Addresses
    {
        get;
        set;
    }
}
