using System;
using System.IO;
using System.Net.Mail;
using System.Text;
using Kros.KORM;
using Kros.KORM.Metadata.Attribute;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var connectionString = args[0];
                var mailTo = args[1];
                var division = int.Parse(args[2]);

                using(var database = new Database(connectionString, "System.Data.SqlClient"))
                {
                    var sb = new StringBuilder();
                    var people = database
                        .Query<Person>()
                        .Where(p => p.Division == division);

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

                    using(var client = new SmtpClient("myServerHost"))
                    using(var mailMessage = new MailMessage())
                    {
                        // ..
                        mailMessage.To.Add(mailTo);
                        mailMessage.Body = sb.ToString();

                        client.Send(mailMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\log.log", ex.ToString());
                throw;
            }
        }
    }
}