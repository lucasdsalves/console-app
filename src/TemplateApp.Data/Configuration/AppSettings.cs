using Microsoft.Extensions.Configuration;

namespace TemplateApp.Data.Configuration
{
    public class EndPoint
    {
        public string UrlWebApi { get; set; }
    }

    public class AppSettings
    {
        public EndPoint EndPoints { get; set; }

        public string Application { get; set; }

        public AppSettings()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"));

            var root = builder.Build();

            root.Bind(this);
        }
    }
}
