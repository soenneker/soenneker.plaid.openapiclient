using Soenneker.Tests.HostedUnit;

namespace Soenneker.Plaid.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PlaidOpenApiClientTests : HostedUnitTest
{
    public PlaidOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
