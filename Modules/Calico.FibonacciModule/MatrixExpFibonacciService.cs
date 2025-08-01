using Calico.MatrixModule;
using System.Numerics;

namespace Calico.FibonacciModule;

public class MatrixExpFibonacciService : BaseFibonacciService
{
    public MatrixExpFibonacciService(uint indexZero, uint indexOne) : base(indexZero, indexOne)
    {
    }

    public override BigInteger GetFibonacciAtIndex(uint index)
    {
        if (Cache.TryGetValue(index, out var valueFromCache))
        {
            return valueFromCache;
        }
        
        var matrix = new Matrix(2, 2)
        {
            [0, 0] = 1,
            [0, 1] = 1,
            [1, 0] = 1,
            [1, 1] = 0
        };

        matrix = matrix.Power(index - 1);
        
        var fibonacciAtIndex = matrix[0, 0] * IndexOne + matrix[0, 1] * IndexZero;
        Cache[index] = fibonacciAtIndex;
        
        return fibonacciAtIndex;
    }
}