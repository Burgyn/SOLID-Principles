using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class CachedPeopleRepository : IPeopleRepository
    {
        private ConcurrentDictionary<int, IEnumerable<Person>> _cachedValues = new ConcurrentDictionary<int, IEnumerable<Person>>();
        private IPeopleRepository _peopleRepository;

        public CachedPeopleRepository(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public IEnumerable<Person> GetPeopleByDivision(int division) =>
            _cachedValues.GetOrAdd(division, x => _peopleRepository.GetPeopleByDivision(division));
    }
}