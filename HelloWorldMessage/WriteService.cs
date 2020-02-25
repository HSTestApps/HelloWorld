using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HelloWorldMessage.Services;


namespace HelloWorldMessage
{
    class WriteService
    {
        private IMessageService _writeService;
        public WriteService()
        {
            var builder = new ConfigurationBuilder()
                           .AddJsonFile("appsettings.json", true, true);

            var config = builder.Build();

            var service = ConfigureServices(config["destination"]);

            var serviceProvider = service.BuildServiceProvider();

            _writeService = serviceProvider.GetService<IMessageService>();

        }
        private IServiceCollection ConfigureServices(string destination)
        {
            IServiceCollection services = new ServiceCollection();

            bool consoleapp = destination.Equals("console", StringComparison.OrdinalIgnoreCase);

            if (consoleapp)
            {
                services.AddTransient<IMessageService, ConsoleMessageService>();
            }
            else
            {
                services.AddTransient<IMessageService, DatabaseMessageService>();
            }

            return services;
        }

        public bool WriteMessage(string message)
        {
            return _writeService.SendMessage(message);
        }
    }
}
