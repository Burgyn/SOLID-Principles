using System;
using System.Collections.Generic;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class XmlPeopleRepository : IPeopleRepository
    {
        public IEnumerable<Person> GetPeopleByDivision(int division) =>
            throw new NotImplementationException("Tu by mal byť veľmi zaujímavý kód, ktorý by deserializoval osoby z Xml dokumentu do zoznamu Person.");
    }
}