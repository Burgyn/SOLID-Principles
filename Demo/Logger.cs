using System.IO;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class Logger: ILogger
    {
        public void LogMessage(string message) =>
            File.WriteAllText(@"C:\log.log", message);
    }
}