namespace MMLib.Demo.SOLIDPrinciples
{
    public class PeopleImportService
    {
        public void Import(IPeopleRepository source, IPeopleRepository target)
        {
            foreach (var person in source.GetAll())
            {
                target.Add(person);
            }

            target.CommitChanges();
        }
    }
}