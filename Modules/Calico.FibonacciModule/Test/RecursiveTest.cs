using System.Numerics;
using Calico.FibonacciModule.Test.TestData;

namespace Calico.FibonacciModule.Test;

public class RecursiveTest
{
    [Theory]
    [ClassData(typeof(FibonacciTestData))]
    public void Should_Return_Correct_Fibonacci(uint index, BigInteger expected)
    {
        var service = new RecursiveFibonacciService(indexZero: 0, indexOne: 1);
        
        var result = service.GetFibonacciAtIndex(index);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [ClassData(typeof(FibonacciSumTestData))]
    public void Should_Return_Correct_Fibonacci_Sum(uint index, BigInteger expected)
    {
        var service = new RecursiveFibonacciService(indexZero:0, indexOne: 1);
        
        var result = service.GetFibonacciSumAtIndex(index);
        
        Assert.Equal(expected, result);
    }
}