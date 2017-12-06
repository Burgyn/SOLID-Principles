using System.Net.Mail;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class MailServer : IMailServer
    {
        public void SendMail(string to, string body)
        {
            using(var client = new SmtpClient("myServerHost"))
            using(var mailMessage = new MailMessage())
            {
                // ..
                mailMessage.To.Add(to);
                mailMessage.Body = body;

                client.Send(mailMessage);
            }
        }
    }
}