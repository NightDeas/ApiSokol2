using Microsoft.EntityFrameworkCore;
using Polly;

namespace WebApi
{
    public class MigrationHostedService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<MigrationHostedService> _logger;

        public MigrationHostedService(IServiceProvider serviceProvider, ILogger<MigrationHostedService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var retryPolicy = Policy
                .Handle<Exception>(ex => ex is DbUpdateException || ex is TimeoutException)
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(5), (exception, timeSpan, retryCount, context) =>
                {
                    _logger.LogWarning(exception, $"Attempt {retryCount} of 3 failed with exception {exception.GetType().Name}. Waiting {timeSpan} before next retry.");
                });

            await retryPolicy.ExecuteAsync(async () =>
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<Context>();
                    _logger.LogInformation("Applying migrations...");
                    await dbContext.Database.MigrateAsync(cancellationToken);
                    _logger.LogInformation("Migrations applied successfully.");
                }
            });
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("MigrationHostedService is stopping.");
            return Task.CompletedTask;
        }
    }
}