using Kros.Utils;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleReportService
    {
        private IReadOnlyPeopleRepository _peopleRepository;
        private IMailServer _mailServer = new MailServer();
        private IPeopleReportDataFormatter _reportDataFormatter = new PeopleReportDataFormatter();

        public PeopleReportService(IReadOnlyPeopleRepository peopleRepository)
        {
            Check.NotNull(peopleRepository, nameof(peopleRepository));

            _peopleRepository = peopleRepository;
        }

        public void SendReport(int derpartment, string mailTo)
        {
            var people = _peopleRepository.GetPeopleByDivision(derpartment);
            var body = _reportDataFormatter.FormatData(people);

            _mailServer.SendMail(mailTo, body);
        }
    }
}
