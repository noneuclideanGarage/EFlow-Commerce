namespace Orders.IntegrationTests.Infrastructure;

[Collection(nameof(IntegrationTestCollection))]
public abstract class IntegrationTestBase : IAsyncLifetime
{
    protected readonly HttpClient Client;
    protected readonly OrderApiFactory Factory;

    protected IntegrationTestBase(OrderApiFactory factory)
    {
        Factory = factory;
        Client = factory.CreateClient();
    }

    public async Task InitializeAsync()
    {
        await Factory.ResetDatabaseAsync();
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    protected void Debug<T>(T value)
    {
        Console.WriteLine($"[[DEBUG]] {value}");
    }
}
