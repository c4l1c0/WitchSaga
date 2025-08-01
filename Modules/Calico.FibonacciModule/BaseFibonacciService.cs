using System.Numerics;

namespace Calico.FibonacciModule;

public abstract class BaseFibonacciService : IFibonacciService
{
    protected readonly Dictionary<uint, BigInteger> Cache;
    protected readonly BigInteger IndexZero, IndexOne;

    protected BaseFibonacciService(uint indexZero, uint indexOne)
    {
        IndexZero = indexZero;
        IndexOne = indexOne;
        
        Cache = new Dictionary<uint, BigInteger>
        {
            [0] = IndexZero,
            [1] = IndexOne
        };
    }

    public abstract BigInteger GetFibonacciAtIndex(uint index);
    
    public virtual BigInteger GetFibonacciSumAtIndex(uint index)
    {
        //Using formula from here for faster fibonacci calculation
        //https://web.archive.org/web/20240713224358/https://proofwiki.org/wiki/Sum_of_Sequence_of_Fibonacci_Numbers
        return GetFibonacciAtIndex(index + 2) - GetFibonacciAtIndex(1);
    }
}