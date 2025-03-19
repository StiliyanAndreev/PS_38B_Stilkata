using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace WelcomeExtended.Helpers
{
    public static class LoggerHelper
    {
        private static ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        public static ILogger GetLogger(string category)
        {
            return loggerFactory.CreateLogger(category);
        }
    }
}
