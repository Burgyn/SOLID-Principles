using System;
using System.Collections.Generic;
using System.Linq;
using Kros.KORM;
using Kros.KORM.Query;
using Kros.Utils;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleRepository : IPeopleRepository
    {
        private IDatabase _database = new Database("connectionString", "System.Data.SqlClient");
        private IDbSet<Person> _dbSet;

        public PeopleRepository()
        {
            _dbSet = _database.Query<Person>().AsDbSet();
        }

        public virtual void Add(Person person) =>
            _dbSet.Add(person);

        public virtual void CommitChanges() =>
            _dbSet.CommitChanges();

        public virtual IEnumerable<Person> GetAll() =>
            _dbSet;

        public virtual IEnumerable<Person> GetPeopleByDepartment(int department) =>
            GetAll().Where(p => p.Department == department);
    }
}