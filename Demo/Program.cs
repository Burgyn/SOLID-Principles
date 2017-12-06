using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using Kros.KORM;
using Kros.KORM.Metadata.Attribute;

namespace MMLib.Demo.SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            try
            {
                var mailTo = args[0];
                var division = int.Parse(args[1]);

                //var peopleRepository = new PeopleRepository();
                //var peopleRepository = new XmlPeopleRepository();
                var peopleRepository = new CachedPeopleRepository(new PeopleRepository());

                var reportService = new PeopleReportService(peopleRepository);

                reportService.SendReport(division, mailTo);
            }
            catch (Exception ex)
            {
                logger.LogMessage(ex.ToString());
                throw;
            }
        }
    }
}