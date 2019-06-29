using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecks.SomeModelService.Health
{
    public class ApiHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = new CancellationToken())
        {
            //TODO: Implement your own healthcheck logic here
            var isHealthy = true;
            if(isHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("healthy"));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("unhealthy"));
        }
    }
}