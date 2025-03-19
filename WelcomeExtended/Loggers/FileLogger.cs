using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;
        private readonly string _name;

        public FileLogger(string name, string filePath)
        {
            _name = name;
            _filePath = filePath;
        }

        public IDisposable BeginScope<TState>(TState state) where TState : notnull
        {
            return NullScope.Instance;
        }

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (formatter == null)
                throw new ArgumentNullException(nameof(formatter));

            var message = formatter(state, exception);
            var logEntry = $"[{DateTime.Now}] [{eventId.Id}] {_name}: {message}\n";
            var fileLogger = new FileLogger("FileLogger", "log.txt");


            File.AppendAllText(_filePath, logEntry);

            Console.WriteLine($"Logged to file: {logEntry}");
        }
    }
}
