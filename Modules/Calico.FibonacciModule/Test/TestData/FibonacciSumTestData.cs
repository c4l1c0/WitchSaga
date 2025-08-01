using System.Collections;

namespace Calico.FibonacciModule.Test.TestData;

public class FibonacciSumTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 0, 0 };
        yield return new object[] { 1, 1 };
        yield return new object[] { 2, 2 };
        yield return new object[] { 3, 4 };
        yield return new object[] { 4, 7 };
        yield return new object[] { 5, 12 };
        yield return new object[] { 6, 20 };
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}