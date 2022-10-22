using FluentAssertions;
using Microsoft.Extensions.Options;
using Moq.Protected;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindERP.Connector.Modules.Accounting;
using BindERP.Connector.Modules.Core;
using BindERP.Connector.Modules.Communications;
using BindERP.Connector.Modules.Inventory;
using BindERP.Connector.Modules.Purchasing;
using BindERP.Connector.Modules.Sales;
using BindERP.Connector.Modules.Treasury;
using BindERP.Connector.Modules.Webhooks;

namespace BindERP.Connector.Tests
{
    public class BindClientTests
    {
        [Fact]
        public void BindClient_ShouldBeConfiguredTest()
        {
            var accounting = new Mock<IAccountingModule>();
            var core = new Mock<ICoreModule>();
            var communications = new Mock<ICommunicationsModule>();
            var inventory = new Mock<IInventoryModule>();
            var purchasing = new Mock<IPurchasingModule>();
            var sales = new Mock<ISalesModule>();
            var treasury = new Mock<ITreasuryModule>();
            var webhooks = new Mock<IWebhooksModule>();

            var client = new BindClient(accounting.Object, core.Object, communications.Object, inventory.Object, purchasing.Object, sales.Object, treasury.Object, webhooks.Object);

            client.Should().NotBeNull();
            client.AccountingServices.Should().NotBeNull();
            client.CoreServices.Should().NotBeNull();
            client.CommunicationsServices.Should().NotBeNull();
            client.InventoryServices.Should().NotBeNull();
            client.PurchasingServices.Should().NotBeNull();
            client.SalesServices.Should().NotBeNull();
            client.TreasuryServices.Should().NotBeNull();
            client.WebhooksServices.Should().NotBeNull();
        }
    }
}
