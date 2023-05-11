using NetMQ;
using NetMQ.Sockets;

namespace MetaTraderDream.Api.Core.BackgroundServices;

public class SignalReceiver : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly ILogger<SignalReceiver> _logger;
    private Dictionary<string, long> _genres = new Dictionary<string, long>();
    public SignalReceiver(IServiceScopeFactory scopeFactory, ILogger<SignalReceiver> logger)
    {
        _scopeFactory = scopeFactory;
        _logger = logger;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using (var receiver = new PullSocket("@tcp://127.0.0.1:5555"))
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(20);
                try
                {
                    string message = receiver.ReceiveFrameString();
                    _logger.LogInformation($"Received Signal: {message}");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Exception in BackgroundService: {nameof(SignalReceiver)} - {ex?.InnerException?.Message ?? ex?.Message}");
                }
            }
        }
    }
}
