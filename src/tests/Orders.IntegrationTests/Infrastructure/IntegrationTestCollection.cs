namespace Orders.IntegrationTests.Infrastructure;

[CollectionDefinition(nameof(IntegrationTestCollection))]
public sealed class IntegrationTestCollection 
    : ICollectionFixture<OrderApiFactory>
{
}
