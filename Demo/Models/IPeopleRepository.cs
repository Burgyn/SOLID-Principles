using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetPeopleByDivision(int division);
        IEnumerable<Person> GetAll();
        void Add(Person person);
        void CommitChanges();
    }
}