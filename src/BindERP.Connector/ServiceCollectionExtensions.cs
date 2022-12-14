using System.Reflection;
using BindERP.Connector.Modules.Accounting;
using BindERP.Connector.Modules.Communications;
using BindERP.Connector.Modules.Core;
using BindERP.Connector.Modules.Inventory;
using BindERP.Connector.Modules.Purchasing;
using BindERP.Connector.Modules.Sales;
using BindERP.Connector.Modules.Treasury;
using BindERP.Connector.Modules.Webhooks;
using Microsoft.Extensions.DependencyInjection;

namespace BindERP.Connector
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBindClient(this IServiceCollection services)
        {
            services.AddOptions<BindOptions>()
                    .Configure(options =>
                    {
                        options.EndpointUri     = "https://api.bind.com.mx";
                        options.EndpointKey     = string.Empty;
                        options.SubscriptionKey = string.Empty;
                    });

            RegisterBindServices(services);

            return services;
        }

        public static IServiceCollection AddBindClient(this IServiceCollection services, Action<BindOptions> options)
        {
            services.Configure(options);

            RegisterBindServices(services);

            return services;
        }

        private static void RegisterBindServices(IServiceCollection services)
        {
            services.AddHttpClient("bind-api-client");
            services.AddScoped<IBindConnection, BindConnection>();
            services.AddScoped<IAccountingModule, AccountingModule>();
            services.AddScoped<ICommunicationsModule, CommunicationsModule>();
            services.AddScoped<ICoreModule, CoreModule>();
            services.AddScoped<IInventoryModule, InventoryModule>();
            services.AddScoped<IPurchasingModule, PurchasingModule>();
            services.AddScoped<ISalesModule, SalesModule>();
            services.AddScoped<ITreasuryModule, TreasuryModule>();
            services.AddScoped<IWebhooksModule, WebhooksModule>();
            services.AddScoped<IBindClient, BindClient>();

            Assembly assembly = typeof(IBindClient).Assembly;

            assembly.GetTypes()
                    .Where(a => a.Name.EndsWith("Service", StringComparison.OrdinalIgnoreCase) && !a.IsAbstract && !a.IsInterface)
                    .Select(a => new { ImplementationType = a, ServiceTypes = a.GetInterfaces().Where(i => i.Name.EndsWith("Service", StringComparison.OrdinalIgnoreCase)).ToList() })
                    .ToList()
                    .ForEach(registration =>
                    {
                        registration.ServiceTypes.ForEach(serviceType =>
                        {
                            services.AddTransient(serviceType, registration.ImplementationType);
                        });
                    });
        }
    }
}
