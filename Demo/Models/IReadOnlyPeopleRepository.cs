using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IReadOnlyPeopleRepository
    {

        IEnumerable<Person> GetPeopleByDivision(int division);
        IEnumerable<Person> GetAll();
    }
}