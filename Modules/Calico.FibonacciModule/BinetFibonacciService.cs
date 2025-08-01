using System.Numerics;

namespace Calico.FibonacciModule;

public class BinetFibonacciService : BaseFibonacciService
{
    private readonly double _rootFive = Math.Sqrt(5);
    private readonly double _phi = (1 + Math.Sqrt(5)) / 2;
    private readonly double _psi = (1 - Math.Sqrt(5)) / 2;

    public BinetFibonacciService(uint indexZero, uint indexOne) : base(indexZero, indexOne)
    {
    }

    public override BigInteger GetFibonacciAtIndex(uint index)
    {
        if (Cache.TryGetValue(index, out var valueFromCache))
        {
            return valueFromCache;
        }
        
        var binetResult = (Math.Pow(_phi, index) - Math.Pow(_psi, index)) / _rootFive;
        var fibonacciAtIndex = (BigInteger) Math.Round(binetResult);
        Cache[index] = fibonacciAtIndex;

        return fibonacciAtIndex;
    }
}