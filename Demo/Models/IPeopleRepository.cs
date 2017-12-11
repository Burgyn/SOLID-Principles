using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetPeopleByDepartment(int department);
        IEnumerable<Person> GetAll();
        void Add(Person person);
        void CommitChanges();
    }
}