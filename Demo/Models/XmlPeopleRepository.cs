using System;
using System.Collections.Generic;
using System.Linq;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class XmlPeopleRepository : IPeopleRepository
    {
        public void Add(Person person)
        {
            // Tu by mal byť kód, ktorý pridá osobu do zoznamu.
        }

        public void CommitChanges()
        {
            // Tu by mal byť kód, ktorý uloží dáta do Xml súboru.
        }

        public IEnumerable<Person> GetAll()
        {
            // Tu by mal byť pekný kód, ktorý deserializuje osoby z Xml.
            return new List<Person>();
        }

        public IEnumerable<Person> GetPeopleByDivision(int division) =>
            GetAll().Where(p => p.Division == division);

    }
}