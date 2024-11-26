namespace Adapter
{
    public class LegacyLogger
    {
        public void WriteToLog(string logMessage)
        {
            Console.WriteLine($"[LegacyLogger]: {logMessage}");
        }
    }

}
