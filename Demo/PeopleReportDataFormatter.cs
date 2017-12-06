using System.Collections.Generic;
using System.Text;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleReportDataFormatter: IPeopleReportDataFormatter
    {
        public string FormatData(IEnumerable<Person> people)
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"<html>
                                    <body>
                                        <table>");
            sb.AppendLine(@"<tr>
                                    <th>Firstname</th>
                                    <th>Lastname</th>
                                    <th>Age</th>
                                </tr>");

            foreach (var person in people)
            {
                sb.Append($@"<tr>
                                        <td>{person.FirstName}</td>
                                        <td>{person.LastName}</td>
                                        <td>{person.Age}</td>
                                    </tr>");
            }

            sb.AppendLine("</table></body></html>");

            return sb.ToString();
        }
    }
}