namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleReportService
    {
        private PeopleRepository _peopleRepository = new PeopleRepository();
        private MailServer _mailServer = new MailServer();
        private PeopleReportDataFormatter _reportDataFormatter = new PeopleReportDataFormatter();

        public void SendReport(int department, string mailTo)
        {
            var people = _peopleRepository.GetPeopleByDepartment(department);
            var body = _reportDataFormatter.FormatData(people);

            _mailServer.SendMail(mailTo, body);
        }
    }
}