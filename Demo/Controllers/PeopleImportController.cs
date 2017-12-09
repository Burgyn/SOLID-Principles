using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kros.Utils;
using Microsoft.AspNetCore.Mvc;

namespace MMLib.Demo.SOLIDPrinciples.Controllers
{
    [Route("api/[controller]")]
    public class PeopleImportController : Controller
    {
        private readonly IPeopleImportService _peopleImportService;
        private readonly IReadOnlyPeopleRepository _sourceRepository;
        private readonly IWritablePeopleRepository _targetRepository;

        public PeopleImportController(IPeopleImportService peopleImportService,
            IReadOnlyPeopleRepository sourceRepository,
            IWritablePeopleRepository targetRepository)
        {
            Check.NotNull(peopleImportService, nameof(peopleImportService));
            Check.NotNull(sourceRepository, nameof(sourceRepository));
            Check.NotNull(targetRepository, nameof(targetRepository));

            this._peopleImportService = peopleImportService;
            this._targetRepository = targetRepository;
            this._sourceRepository = sourceRepository;
        }

        [HttpPost]
        public void Import()
        {
            _peopleImportService.Import(_sourceRepository, _targetRepository);
        }
    }
}