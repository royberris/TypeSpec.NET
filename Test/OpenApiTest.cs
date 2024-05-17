using Xunit;

namespace Test
{
    public class OpenApiTest(IntegrationFixture fixture) : IClassFixture<IntegrationFixture>
    {
        [Fact]
        public async Task GenerateOpenApiFile()
        {
            var response = await fixture.HttpClient.GetAsync("/swagger/v1/swagger.json");

            response.EnsureSuccessStatusCode();

            var dotnetOpenApiSpec = await response.Content.ReadAsStringAsync();

            var solutionDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../.."));
            var openApiFilePath = Path.Combine(solutionDirectory, "dotnet_openapi.json");

            // Save the OpenAPI spec to a file for comparison
            System.IO.File.WriteAllText(openApiFilePath, dotnetOpenApiSpec);

            Assert.True(File.Exists(openApiFilePath));
        }
    }
}