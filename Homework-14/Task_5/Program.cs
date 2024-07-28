namespace Task_5
{
    internal class Program
    {
        public interface ILogger
        {
            public void Log(string message);
        }
        class ConsoleLogger : ILogger
        {
            public void Log(string msg)
            {
                Console.WriteLine(msg);
            }
        }
        class FileLogger : ILogger
        {
            private readonly string _filePath;

            public FileLogger(string filePath)
            {
                _filePath = filePath;
            }

            public void Log(string message)
            {
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine(message);
                }
            }
        }
        public class LoggingService
        {
            private readonly ILogger _logger;

            public LoggingService(ILogger logger)
            {
                _logger = logger;
            }

            public void PerformLogging(string message)
            {
                _logger.Log(message);
            }
        }

        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            LoggingService consoleLoggingService = new LoggingService(consoleLogger);
            consoleLoggingService.PerformLogging("Logging to console.");

            string filePath = "C:\\Users\\david\\Desktop";
            ILogger fileLogger = new FileLogger(filePath);
            LoggingService fileLoggingService = new LoggingService(fileLogger);
            fileLoggingService.PerformLogging("Logging to file.");

            Console.WriteLine("Logging completed.");
        }
    }
}
