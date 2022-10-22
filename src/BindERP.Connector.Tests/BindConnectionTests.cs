using FluentAssertions;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;

namespace BindERP.Connector.Tests;

public class BindConnectionTests
{
    [Fact]
    public void BindConnection_ShouldBeConfiguredTest()
    {
        var factory    = CreateDefaultHttpFactory();
        var options    = Options.Create(new BindOptions());
        var connection = new BindConnection(factory, options);

        var action     = () => connection.GetClient();
        action.Should()
              .Throw<InvalidOperationException>()
              .WithMessage("The Bind ERP API key is not valid. Please ensure it's in the appropiate configuration section.");
    }

    [Fact]
    public void BindConnection_ShoudUseOptionsTest()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions()
        {
            EndpointKey     = "EndpointKey",
            SubscriptionKey = "SubscriptionKey"
        }); ;

        var connection = new BindConnection(factory, options);

        var client = connection.GetClient();

        client.Should().NotBeNull();

        client.BaseAddress.Should().Be(new Uri("https://api.bind.com.mx", UriKind.Absolute));

        client.DefaultRequestHeaders.Authorization.Should().NotBeNull();
        
        var values = client.DefaultRequestHeaders.GetValues("Ocp-Apim-Subscription-Key");
        values.Should().NotBeNull();
        values.Should().HaveCount(1);

        var subscription = values.First();
        subscription.Should().Be("SubscriptionKey");
    }

    [Fact]
    public void BindConnection_ShoudUseDefaultEndpointUriIfInvalidTest()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions()
        {
            EndpointUri = "/hola",
            EndpointKey = "EndpointKey",
        }); ;

        var connection = new BindConnection(factory, options);
        var client = connection.GetClient();

        client.Should().NotBeNull();
        client.BaseAddress.Should().Be(new Uri("https://api.bind.com.mx", UriKind.Absolute));
    }

    [Fact]
    public void BindConnection_ShouldUseSetupValues()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions());

        var connection = new BindConnection(factory, options);

        connection.SetEndpointUri("https://www.test.com");
        connection.SetEndpointKey("EndpointKey");
        connection.SetSubscriptionKey("Subscription");

        var client = connection.GetClient();

        client.Should().NotBeNull();

        client.BaseAddress.Should().Be(new Uri("https://www.test.com", UriKind.Absolute));

        var auth = client.DefaultRequestHeaders.GetValues("Authorization");
        auth.Should().NotBeNull();
        auth.Should().HaveCount(1);
        var key = auth.First();

        key.Should().Be("Bearer EndpointKey");

        var values = client.DefaultRequestHeaders.GetValues("Ocp-Apim-Subscription-Key");
        values.Should().NotBeNull();
        values.Should().HaveCount(1);

        var subscription = values.First();
        subscription.Should().Be("Subscription");
    }


    [Fact]
    public void BindConnection_ShouldNotAllowEmptyUrisTest()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions()
        {
            EndpointKey = "DefaultKey"
        });

        var connection = new BindConnection(factory, options);

        var client = connection.GetClient();

        Action action = () => connection.SetEndpointUri(string.Empty);

        action.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void BindConnection_ShouldNotAllowRelativeUrisTest()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions()
        {
            EndpointKey = "EndpointKey"
        });

        var connection = new BindConnection(factory, options);

        var client = connection.GetClient();

        Action action = () => connection.SetEndpointUri("/relative/uri");

        action.Should().Throw<ArgumentException>();

        Action action2 = () => connection.SetEndpointUri(new Uri("/relative/uri", UriKind.Relative));
        action2.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void BindConnection_ShouldNotAllowEmptyKeysTest()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions()
        {
            EndpointKey = "EndpointKey"
        });

        var connection = new BindConnection(factory, options);
        var client     = connection.GetClient();

        var action  = () => connection.SetEndpointKey(string.Empty);
        action.Should().Throw<ArgumentNullException>();

        var action2 = () => connection.SetSubscriptionKey(string.Empty);
        action2.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void BindConnection_ShouldReturnExistingClientTest()
    {
        var factory    = CreateDefaultHttpFactory();
        var options    = Options.Create(new BindOptions()
        {
            EndpointKey     = "EndpointKey",
            SubscriptionKey = "SubscriptionKey"
        });

        var connection = new BindConnection(factory, options);
        var client     = connection.GetClient();

        client.Should().NotBeNull();

        connection.SetEndpointUri("https://www.test.com");
        connection.SetEndpointKey("NewEndpointKey");
        connection.SetSubscriptionKey("NewSubscriptionKey");

        var client2 = connection.GetClient();
        client2.Should().BeSameAs(client);

        client2.BaseAddress.Should().Be(new Uri("https://www.test.com", UriKind.Absolute));
        var auth = client2.DefaultRequestHeaders.GetValues("Authorization");
        auth.Should().NotBeNull();
        auth.Should().HaveCount(1);
        var key = auth.First();

        key.Should().Be("Bearer NewEndpointKey");

        var values = client2.DefaultRequestHeaders.GetValues("Ocp-Apim-Subscription-Key");
        values.Should().NotBeNull();
        values.Should().HaveCount(1);

        var subscription = values.First();
        subscription.Should().Be("NewSubscriptionKey");

        connection.SetEndpointUri(new Uri("https://www.test2.com", UriKind.Absolute));
        var client3 = connection.GetClient();

        client3.Should().BeSameAs(client);
        client3.Should().BeSameAs(client2);

        client3.BaseAddress.Should().Be(new Uri("https://www.test2.com", UriKind.Absolute));
    }


    [Fact]
    public void BindConnection_ShouldBeDisposedTest()
    {
        var factory = CreateDefaultHttpFactory();
        var options = Options.Create(new BindOptions()
        {
            EndpointKey = "Key"
        }); ;

        var connection = new BindConnection(factory, options);
        var client = connection.GetClient();

        connection.Dispose();

        Action action1 = () => connection.SetEndpointUri("/relative/uri");

        action1.Should().Throw<ObjectDisposedException>();

        Action action2 = () => connection.SetEndpointKey("key");

        action2.Should().Throw<ObjectDisposedException>();

        Action action3 = () => connection.SetSubscriptionKey("key");

        action3.Should().Throw<ObjectDisposedException>();

        Action action4 = () => connection.SetEndpointUri(new Uri("https://www.test.com"));

        action4.Should().Throw<ObjectDisposedException>();

        Action action5 = () => connection.GetClient();
        action5.Should().Throw<ObjectDisposedException>();

        Action action6 = () => connection.Dispose();
        action6.Should().Throw<ObjectDisposedException>();
    }

    private static IHttpClientFactory CreateDefaultHttpFactory()
    {
        var handler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
        var factory = new Mock<IHttpClientFactory>();
        var result  = new HttpResponseMessage();

        // Setup handler with base methods and disposable pattern.
        handler.Protected()
               .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(result)
               .Verifiable();

        handler.Protected()
               .Setup("Dispose", ItExpr.IsAny<bool>());

        handler.As<IDisposable>()
               .Setup(x => x.Dispose());

        // Setup HttpClient
        var client  = new HttpClient(handler.Object);

        // Setup HttpClientFactory
        factory.Setup(x => x.CreateClient("bind-api-client"))
               .Returns(client);

        return factory.Object;
    }
}
