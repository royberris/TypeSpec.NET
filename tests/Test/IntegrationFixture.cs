using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test;

public class IntegrationFixture : IAsyncLifetime
{
    public HttpClient HttpClient;

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public async Task InitializeAsync()
    {
        var factory = new CustomWebApplicationFactory();

        HttpClient = factory.CreateClient();
    }
}
