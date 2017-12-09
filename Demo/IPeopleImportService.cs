namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IPeopleImportService
    {
        void Import(IReadOnlyPeopleRepository source, IWritablePeopleRepository target);
    }
}