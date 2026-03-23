using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Plaid.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class PlaidOpenApiClientTests : FixturedUnitTest
{
    public PlaidOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
