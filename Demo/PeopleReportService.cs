using Kros.Utils;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleReportService : IPeopleReportService
    {
        private IReadOnlyPeopleRepository _peopleRepository;
        private IMailServer _mailServer;
        private IPeopleReportDataFormatter _reportDataFormatter;

        public PeopleReportService(IReadOnlyPeopleRepository peopleRepository,
            IMailServer mailServer,
            IPeopleReportDataFormatter peopleReportDataFormatter)
        {
            Check.NotNull(peopleRepository, nameof(peopleRepository));
            Check.NotNull(mailServer, nameof(mailServer));
            Check.NotNull(peopleReportDataFormatter, nameof(peopleReportDataFormatter));

            _peopleRepository = peopleRepository;
            _reportDataFormatter = peopleReportDataFormatter;
            _mailServer = mailServer;
        }

        public void SendReport(int division, string mailTo)
        {
            var people = _peopleRepository.GetPeopleByDivision(division);
            var body = _reportDataFormatter.FormatData(people);

            _mailServer.SendMail(mailTo, body);
        }
    }
}
