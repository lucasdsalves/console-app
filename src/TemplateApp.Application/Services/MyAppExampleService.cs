using TemplateApp.Application.Interfaces;
using TemplateApp.Data.Configuration;

namespace TemplateApp.Application.Services
{
    public class MyAppExampleService : IMyAppExampleService
    {
        private readonly AppSettings _appSettings;

        public MyAppExampleService(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public Task<string> ShowAppSettingsUse()
        {
            var urlFromAppSettings = _appSettings.EndPoints.UrlWebApi;

            return Task.FromResult(urlFromAppSettings);
        }
    }
}
