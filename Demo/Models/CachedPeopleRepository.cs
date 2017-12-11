using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class CachedPeopleRepository : IPeopleRepository
    {
        private ConcurrentDictionary<int, IEnumerable<Person>> _cachedValues = new ConcurrentDictionary<int, IEnumerable<Person>>();
        private Lazy<IEnumerable<Person>> _all;
        private IPeopleRepository _peopleRepository;

        public CachedPeopleRepository(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
            _all = new Lazy<IEnumerable<Person>>(() => _peopleRepository.GetAll());
        }

        public void Add(Person person) =>
            _peopleRepository.Add(person);

        public void CommitChanges() =>
            _peopleRepository.CommitChanges();

        public IEnumerable<Person> GetAll() =>
            _peopleRepository.GetAll();

        public IEnumerable<Person> GetPeopleByDivision(int derpartment) =>
            _cachedValues.GetOrAdd(derpartment, x => _peopleRepository.GetPeopleByDivision(derpartment));

    }
}