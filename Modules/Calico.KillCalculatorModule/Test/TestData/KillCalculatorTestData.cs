using System.Collections;
using System.Numerics;

namespace Calico.KillCalculatorModule.Test.TestData;

public class KillCalculatorTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        var caseOne = new IDeathInfo[]
        {
            new DeathInfo(10, 12),
            new DeathInfo(13, 17)
        };
        var caseTwo = new IDeathInfo[]
        {
            new DeathInfo(10, 110),
            new DeathInfo(1, 1)
        };
        yield return new object[] { caseOne, 4.5 };
        yield return new object[] { caseTwo, 177112424089630957537.5 };
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
