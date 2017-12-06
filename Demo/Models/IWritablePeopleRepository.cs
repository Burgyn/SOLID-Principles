namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IWritablePeopleRepository
    {
        void Add(Person person);
        void CommitChanges();
    }
}