using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IReadOnlyPeopleRepository
    {

        IEnumerable<Person> GetPeopleByDepartment(int department);
        IEnumerable<Person> GetAll();
    }
}