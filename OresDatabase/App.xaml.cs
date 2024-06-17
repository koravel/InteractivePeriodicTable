using Microsoft.Extensions.Configuration;
using OresDatabase.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace OresDatabase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly string configFileLocation = "appsettings.json";

        private ConfigurationLib.Configuration _configuration;
        private Database _database;

        public App()
        {
            _configuration = new ConfigurationLib.Configuration(builder =>
            {
                builder.AddJsonFile(configFileLocation);
            });
            _database = new Database(_configuration);
        }
    }

}
