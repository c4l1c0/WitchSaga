using System.Numerics;
using Calico.FibonacciModule;

namespace Calico.KillCalculatorModule;

public class KillCalculator : IKillCalculator
{
    private readonly IFibonacciService _fibonacciService;
    
    public KillCalculator(IFibonacciService fibonacciService)
    {
        _fibonacciService = fibonacciService;
    }

    public double GetAverageKills(IDeathInfo[]  deathInfos)
    {
        var sum = deathInfos.Select(info => GetKillsOnBirthYear(info))
            .Aggregate(BigInteger.Zero, (sum, next) => sum + next);
        var count = deathInfos.Length;
        
        return (double) sum / count;
    }
    
    private BigInteger GetKillsOnBirthYear(IDeathInfo deathInfo)
    {
        var birthYear = deathInfo.BirthYear;
        return _fibonacciService.GetFibonacciSumAtIndex(birthYear);
    }
}