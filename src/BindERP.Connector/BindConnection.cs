using BindERP.Connector.Modules.Webhooks.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace BindERP.Connector
{
    public class BindConnection : IDisposable, IBindConnection
    {
        private HttpClient? client;
        private bool disposed;

        private readonly BindOptions options;

        private readonly IHttpClientFactory factory;

        private const string DefaultEndpointUri = "https://api.bind.com.mx";


        private string? endpointKey;

        private string? subscriptionKey;

        private string? endpointUri;

        public BindConnection(IHttpClientFactory factory, IOptions<BindOptions> options)
        {
            this.factory = factory;
            this.options = options.Value;
        }

        public HttpClient GetClient()
        {
            this.ThrowIfDisposed();

            if (this.client is not null)
            {
                return this.client;
            }

            this.client      = factory.CreateClient("bind-api-client");

            var endpoint     = endpointUri             ?? options.EndpointUri     ?? DefaultEndpointUri;
            var token        = endpointKey             ?? options.EndpointKey     ?? string.Empty;
            var subscription = subscriptionKey         ?? options.SubscriptionKey ?? string.Empty;

            if (!Uri.TryCreate(endpoint, UriKind.Absolute, out var endpointBaseAddress))
            {
                endpointBaseAddress = new Uri(DefaultEndpointUri, UriKind.Absolute);
            }

            token        = token.Trim();
            subscription = subscription.Trim();

            if (string.IsNullOrWhiteSpace(token))
            {
                throw new InvalidOperationException("The Bind ERP API key is not valid. Please ensure it's in the appropiate configuration section.");
            }

            this.client.BaseAddress = endpointBaseAddress;
            this.client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            if (!string.IsNullOrWhiteSpace(subscription))
            {
                this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{subscription}");
            }

            return this.client;
        }

        protected void ThrowIfDisposed()
        {
            if (this.disposed)
            { 
                throw new ObjectDisposedException("BindConnection");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            this.ThrowIfDisposed();
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (this.client is not null)
                    {
                        this.client.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BindConnection()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void SetEndpointKey(string endpointKey)
        {
            this.ThrowIfDisposed();

            if (string.IsNullOrWhiteSpace(endpointKey))
            {
                throw new ArgumentNullException(nameof(endpointKey), "The Bind ERP API key is not valid.");
            }

            this.endpointKey = endpointKey;
            if (this.client is not null)
            {
                if (this.client.DefaultRequestHeaders.Contains("Authorization"))
                {
                    this.client.DefaultRequestHeaders.Remove("Authorization");
                }

                this.client.DefaultRequestHeaders.Add("Authorization", $"Bearer {endpointKey}");
            }
        }

        public void SetSubscriptionKey(string subscriptionKey)
        {
            this.ThrowIfDisposed();

            if (string.IsNullOrWhiteSpace(subscriptionKey))
            {
                throw new ArgumentNullException(nameof(subscriptionKey), "The Bind ERP Subscription key is not valid.");
            }

            this.subscriptionKey = subscriptionKey;
            if (this.client is not null)
            {
                if (this.client.DefaultRequestHeaders.Contains("Ocp-Apim-Subscription-Key"))
                {
                    this.client.DefaultRequestHeaders.Remove("Ocp-Apim-Subscription-Key");
                }

                this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{subscriptionKey}");
            }
        }

        public void SetEndpointUri(string endpointUri)
        {
            this.ThrowIfDisposed();

            if (string.IsNullOrWhiteSpace(endpointUri))
            {
                throw new ArgumentNullException(nameof(endpointUri), "The Bind ERP Endpoint URL is required.");
            }

            if (!Uri.TryCreate(endpointUri, UriKind.Absolute, out var endpoint))
            {
                throw new ArgumentException("The Bind ERP Endpoint URL is not absolute.", nameof(endpointUri));
            }

            this.endpointUri = endpointUri;

            if (this.client is not null)
            {
                this.client.BaseAddress = endpoint;
            }
        }

        public void SetEndpointUri(Uri endpointUri)
        {
            this.ThrowIfDisposed();
            if (!endpointUri.IsAbsoluteUri)
            {
                throw new ArgumentException("The Bind ERP Endpoint URL is not absolute.", nameof(endpointUri));
            }

            this.endpointUri = endpointUri.ToString();

            if (this.client is not null)
            {
                this.client.BaseAddress = endpointUri;
            }
        }
    }
}
