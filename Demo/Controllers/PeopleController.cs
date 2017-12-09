using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kros.Utils;
using Microsoft.AspNetCore.Mvc;

namespace MMLib.Demo.SOLIDPrinciples.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly IReadOnlyPeopleRepository _peopleRepository;

        public PeopleController(IReadOnlyPeopleRepository peopleRepository)
        {
            Check.NotNull(peopleRepository, nameof(peopleRepository));

            this._peopleRepository = peopleRepository;
        }

        [HttpGet]
        public IEnumerable<Person> Get()=>
            _peopleRepository.GetAll();
    }
}