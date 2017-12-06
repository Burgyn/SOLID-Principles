using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IPeopleReportDataFormatter
    {
         string FormatData(IEnumerable<Person> people);
    }
}