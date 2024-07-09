using Catalogs.API.context;

namespace Catalogs.API.HostingService
{
    public class AppHostedService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            CatalogDbContextSeed.Seed();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            return Task.CompletedTask;
        }
    }
}
