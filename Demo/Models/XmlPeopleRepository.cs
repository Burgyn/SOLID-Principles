using System;
using System.Collections.Generic;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class XmlPeopleRepository : IPeopleRepository
    {
        public IEnumerable<Person> GetPeopleByDepartment(int department) =>
            throw new NotImplementedException("Tu by mal byť veľmi zaujímavý kód, ktorý by deserializoval osoby z Xml dokumentu do zoznamu Person.");
    }
}