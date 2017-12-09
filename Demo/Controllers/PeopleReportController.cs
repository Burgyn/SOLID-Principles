using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kros.Utils;

namespace MMLib.Demo.SOLIDPrinciples.Controllers
{
    [Route("api/[controller]")]
    public class PeopleReportController : Controller
    {
        private readonly IPeopleReportService _peopleReportService;

        public PeopleReportController(IPeopleReportService peopleReportService)
        {
            Check.NotNull(peopleReportService, nameof(peopleReportService));
            this._peopleReportService = peopleReportService;

        }

        [HttpPost()]
        public void SendReport([FromBody] int division, [FromBody] string mailTo)
        {
            _peopleReportService.SendReport(division, mailTo);
        }
    }
}