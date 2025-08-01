using System.Numerics;

namespace Calico.FibonacciModule;

public interface IFibonacciService
{
    BigInteger GetFibonacciAtIndex(uint index);
    
    BigInteger GetFibonacciSumAtIndex(uint index);
}