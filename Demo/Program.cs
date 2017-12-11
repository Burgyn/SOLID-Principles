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
                if (args[0] == "-r")
                {
                    var mailTo = args[1];
                    var department = int.Parse(args[2]);

                    SendReport(mailTo, department);
                }
                else if (args[0] == "-i")
                {
                    ImportPeople();
                }
            }
            catch (Exception ex)
            {
                logger.LogMessage(ex.ToString());
                throw;
            }
        }

        private static void ImportPeople()
        {
            IPeopleRepository source = new XmlPeopleRepository();
            PeopleRepository target = new PeopleRepository();
            var importService = new PeopleImportService();

            importService.Import(source, target);
        }

        private static void SendReport(string mailTo, int department)
        {
            //var peopleRepository = new PeopleRepository();
            //var peopleRepository = new XmlPeopleRepository();
            var peopleRepository = new CachedPeopleRepository(new PeopleRepository());

            var reportService = new PeopleReportService(peopleRepository);

            reportService.SendReport(department, mailTo);
        }
    }
}