using System.Collections.Generic;

namespace MMLib.Demo.SOLIDPrinciples
{
    public interface IPeopleRepository: IReadOnlyPeopleRepository, IWritablePeopleRepository
    {
    }
}