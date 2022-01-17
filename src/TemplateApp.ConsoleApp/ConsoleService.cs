using Microsoft.Extensions.Hosting;
using TemplateApp.Application.Interfaces;

namespace TemplateApp.ConsoleApp
{
    public class ConsoleService : IHostedService
    {
        private readonly IHostApplicationLifetime _appLifeTime;
        private readonly IMyAppExampleService _myAppService;

        public ConsoleService(IHostApplicationLifetime appLifeTime, IMyAppExampleService myAppService)
        {
            _appLifeTime = appLifeTime;
            _myAppService = myAppService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _appLifeTime.ApplicationStarted.Register(() =>
            {
                Task.Run(async () =>
                {
                    try
                    {
                        await _myAppService.ShowAppSettingsUse();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        _appLifeTime.StopApplication();
                    }
                });
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
