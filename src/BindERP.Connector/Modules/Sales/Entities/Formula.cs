using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Sales.Entities;

public record Formula
{
    public Formula()
    {
        this.Items = new List<FormulaProduct>();
    }

    public Guid ID
    {
        get;
        set;
    }

    public DateTime? CreationDate
    {
        get;
        set;
    }

    public Guid? ProductID
    {
        get;
        set;
    }

    public string? ProductCode
    {
        get;
        set;
    }

    public string? ProductTitle
    {
        get;
        set;
    }

    public string? ProductUnit
    {
        get;
        set;
    }

    public string? Comments
    {
        get;
        set;
    }

    public decimal? AdditionalCosts
    {
        get;
        set;
    }

    public Guid? EmployeeID
    {
        get;
        set;
    }

    public string? EmployeerName
    {
        get;
        set;
    }

    public decimal? Qty
    {
        get;
        set;
    }

    public int? StatusCode
    {
        get;
        set;
    }

    public string? Status
    {
        get;
        set;
    }

    public string? Title
    {
        get;
        set;
    }

    [JsonProperty("ProductionFormulaItems")]
    public IEnumerable<FormulaProduct> Items
    {
        get;
    }
}
