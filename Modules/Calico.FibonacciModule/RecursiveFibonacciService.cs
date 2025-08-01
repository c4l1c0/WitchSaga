using System.Numerics;

namespace Calico.FibonacciModule;

public class RecursiveFibonacciService : BaseFibonacciService
{
    public RecursiveFibonacciService(uint indexZero, uint indexOne) : base(indexZero, indexOne)
    {
    }

    public override BigInteger GetFibonacciAtIndex(uint index)
    {
        if (Cache.TryGetValue(index, out var valueFromCache))
        {
            return valueFromCache;
        }
        
        var fibonacciAtIndex = GetFibonacciAtIndex(index - 1) + GetFibonacciAtIndex(index - 2);
        Cache[index] = fibonacciAtIndex;
        return fibonacciAtIndex;
    }
}