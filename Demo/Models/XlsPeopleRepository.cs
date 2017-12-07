using System;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class XlsPeopleRepository : PeopleRepository
    {
        public override void Add(Person person) =>
            throw new NotImplementedException("Repository is ReadOnly");

        public override void CommitChanges() =>
            throw new NotImplementedException("Repository is ReadOnly");
    }
}
