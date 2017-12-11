using System.Collections.Generic;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class DummyPeopleRepository : IReadOnlyPeopleRepository
    {

        private IEnumerable<Person> _data = new List<Person>() {
            new Person(){ FirstName = "Milan", LastName = "Martiniak", Age = 32, Department = 1},
            new Person(){ FirstName = "Peter", LastName = "Michal", Age = 21, Department = 1},
            new Person(){ FirstName = "Marek", LastName = "Vojčiniak", Age = 31, Department = 1},
            new Person(){ FirstName = "Zuzana", LastName = "Martiniaková", Age = 31, Department = 2},
        };

        public IEnumerable<Person> GetAll() => _data;

        public IEnumerable<Person> GetPeopleByDepartment(int department) =>
            _data.Where(p => p.Department == department);
    }
}