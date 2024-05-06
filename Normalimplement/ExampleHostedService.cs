

namespace NormalImplement
{
    public class ExampleHostedService : IHostedService
    {
        public async Task StartAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //Console.WriteLine(&quotExample Host Service is working.& quot);
                await Task.Delay(2000, stoppingToken);
            }
            await Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }
    }
}