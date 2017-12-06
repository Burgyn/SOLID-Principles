using System;

namespace MMLib.Demo.SOLIDPrinciples
{
    public class XlsPeopleRepository : PeopleRepository
    {
        public override void Add(Person person) =>
            throw new InvalidOperationException("Repository is ReadOnly");

        public override void CommitChanges() =>
            throw new InvalidOperationException("Repository is ReadOnly");
    }
}