using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace SOLID_Principles.Old
{
    public class PeopleController : Controller
    {

        [HttpGet]
        public IActionResult SendReport([FromBody] string to)
        {
            using (var database = new Database())
            {
                var sb = new StringBuilder();
                var people = database.Query<Person>();

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
                    sb.AppendLine("<tr>");
                    sb.Append($"<td>{person.FirstName}</td><td>{person.LastName}</td><td>{person.Age}</td>");
                    sb.AppendLine("</tr>");
                }

                sb.AppendLine("</table></body></html>");

                using (var client = new SmtpClient("myServerHost"))
                using (var mailMessage = new MailMessage())
                {
                    // ..
                    mailMessage.To.Add(to);
                    mailMessage.Body = sb.ToString();
                    
                    client.Send(mailMessage);
                }
            }

            return Ok();
        }
    }

    internal class Person
    {
        public object FirstName { get; internal set; }
        public object LastName { get; internal set; }
        public object Age { get; internal set; }
    }

    internal class Database : IDisposable
    {
        internal IEnumerable<T> Query<T>()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Database() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}