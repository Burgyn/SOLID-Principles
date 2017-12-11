using Kros.Utils;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleReportService
    {
        private IPeopleRepository _peopleRepository = new PeopleRepository();
        private IMailServer _mailServer = new MailServer();
        private IPeopleReportDataFormatter _reportDataFormatter = new PeopleReportDataFormatter();

        public PeopleReportService(IPeopleRepository peopleRepository)
        {
            Check.NotNull(peopleRepository, nameof(peopleRepository));

            _peopleRepository = peopleRepository;
        }

        public void SendReport(int department, string mailTo)
        {
            var people = _peopleRepository.GetPeopleByDepartment(department);
            var body = _reportDataFormatter.FormatData(people);

            _mailServer.SendMail(mailTo, body);
        }
    }
}