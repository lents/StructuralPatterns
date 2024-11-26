namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the legacy logger instance
            LegacyLogger legacyLogger = new LegacyLogger();

            // Use the adapter to bridge to the new system
            ILogger logger = new LoggerAdapter(legacyLogger);

            // Client code uses the Target interface
            logger.Log("This is a log message.");
        }
    }
}
