using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IReadOnlyPeopleRepository
    {

        IEnumerable<Person> GetPeopleByDepartment(int derpartment);
        IEnumerable<Person> GetAll();
    }
}