using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IReadOnlyPeopleRepository
    {

        IEnumerable<Person> GetPeopleByDivision(int derpartment);
        IEnumerable<Person> GetAll();
    }
}