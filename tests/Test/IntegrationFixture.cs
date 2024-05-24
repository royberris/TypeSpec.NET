namespace Test;

public class IntegrationFixture : IAsyncLifetime
{
    public HttpClient HttpClient;

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        var factory = new CustomWebApplicationFactory();

        HttpClient = factory.CreateClient();

        return Task.CompletedTask;
    }
}
