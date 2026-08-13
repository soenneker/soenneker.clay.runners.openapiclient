using Soenneker.Tests.HostedUnit;

namespace Soenneker.Clay.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ClayOpenApiClientRunnerTests : HostedUnitTest
{
    public ClayOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
