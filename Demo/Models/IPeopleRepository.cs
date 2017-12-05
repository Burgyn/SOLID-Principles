using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> GetPeopleByDivision(int division);
    }
}