using System;
using System.Collections.Generic;
using System.Linq;
using Kros.KORM;
using Kros.Utils;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleRepository
    {
        private IDatabase _database = new Database("connectionString", "System.Data.SqlClient");

        public IEnumerable<Person> GetPeopleByDepartment(int department) =>
            _database.Query<Person>().Where(p => p.Department == department);
    }
}