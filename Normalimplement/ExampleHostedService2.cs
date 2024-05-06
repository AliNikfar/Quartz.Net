namespace NormalImplement
{
    public class ExampleHostedService2 : IHostedService
    {
        public async Task StartAsync(CancellationToken stoppingToken)
        {
            int i = 0;
            while (!stoppingToken.IsCancellationRequested && i != 5)
            {
                Console.WriteLine("&quotExample Hosted Service2 is working.& quot");
                i++;
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
