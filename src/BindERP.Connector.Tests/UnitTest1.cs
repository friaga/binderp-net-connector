using BindERP.Connector.Modules.Sales.Entities;
using BindERP.Connector.Modules.Sales.Services;
using Microsoft.Extensions.Options;

namespace BindERP.Connector.Tests
{
    public class UnitTest1
    {
        public UnitTest1(IHttpClientFactory factory)
        {
            this.factory = factory;
        }

        private readonly IHttpClientFactory factory;

        [Fact]
        public async Task Test1()
        {
            var options = Options.Create(new BindOptions()
            {
                // 
            });

            var connection = new BindConnection(this.factory, options);


            using var client = new ProductsService(connection);

            try
            {
                var product = await client.GetProductAsync(new Guid("31cfc1dc-70fb-48d9-adc6-6fa034ff7f0d"));

                Assert.NotNull(product);

                Console.WriteLine(product.ID);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}