using System.Collections;
using System.Numerics;

namespace Calico.FibonacciModule.Test.TestData;

public class FibonacciTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 0, 0 };
        yield return new object[] { 1, 1 };
        yield return new object[] { 2, 1 };
        yield return new object[] { 3, 2 };
        yield return new object[] { 4, 3 };
        yield return new object[] { 5, 5 };
        yield return new object[] { 14, 377 };
        yield return new object[] { 100, BigInteger.Parse("354224848179261915075") };
        yield return new object[] { 500, BigInteger.Parse("139423224561697880139724382870407283950070256587697307264108962948325571622863290691557658876222521294125") };
        yield return new object[] { 1000, BigInteger.Parse("43466557686937456435688527675040625802564660517371780402481729089536555417949051890403879840079255169295922593080322634775209689623239873322471161642996440906533187938298969649928516003704476137795166849228875") };
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}