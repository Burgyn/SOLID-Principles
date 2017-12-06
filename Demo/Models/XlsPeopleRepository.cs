using System;
using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class XlsPeopleRepository : IReadOnlyPeopleRepository
    {
        private PeopleRepository _peopleRepository;

        public IEnumerable<Person> GetAll() =>
            _peopleRepository.GetAll();

        public IEnumerable<Person> GetPeopleByDivision(int division) =>
            _peopleRepository.GetAll();
    }
}