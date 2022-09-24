using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindERP.Connector.Modules.Core.Entities
{
    public enum DocumentType
    {
        Remissions = 0,
        Invoices = 1,
        Quotes = 2,
        Orders = 3,
        PurchaseOrders = 4,
        Expenses = 5,
        Receptions = 6,
        ProductionOrders = 7,
        CreditNotes = 8,
        MerchandiseTransfers = 9,
    }
}
