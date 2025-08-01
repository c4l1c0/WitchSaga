using Calico.FibonacciModule;
using Calico.KillCalculatorModule.Test.TestData;

namespace Calico.KillCalculatorModule.Test;

public class KillCalculatorTest
{
    [Theory]
    [ClassData(typeof(KillCalculatorTestData))]
    public void Should_Return_Correct_Average(IDeathInfo[]  deathInfos, double expected)
    {
        var fibonacciService = new MatrixExpFibonacciService(0, 1);
        var calculator = new KillCalculator(fibonacciService);
        
        var result = calculator.GetAverageKills(deathInfos);

        Assert.Equal(expected, result);
    }
}