using Microsoft.Extensions.DependencyInjection;
using TemplateApp.Application.Interfaces;
using TemplateApp.Application.Services;
using TemplateApp.Data.Configuration;

namespace TemplateApp.ConsoleApp.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddHostedService<ConsoleService>();

            services.AddSingleton<AppSettings, AppSettings>();

            // Services
            services.AddTransient<IMyAppExampleService, MyAppExampleService>();

            return services;
        }
    }
}
