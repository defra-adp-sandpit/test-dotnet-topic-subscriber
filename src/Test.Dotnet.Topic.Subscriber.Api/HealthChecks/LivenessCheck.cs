using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Test.Dotnet.Topic.Subscriber.Api.HealthChecks;
public class LivenessCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(HealthCheckResult.Healthy("OK"));
    }
}