using System.IO;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class Logger
    {
        public void LogMessage(string message) =>
            File.WriteAllText(@"C:\log.log", message);
    }
}