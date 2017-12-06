namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleImportService
    {
        public void Import(IReadOnlyPeopleRepository source, IWritablePeopleRepository target)
        {
            foreach (var person in source.GetAll())
            {
                target.Add(person);
            }

            target.CommitChanges();
        }
    }
}