using Calico.FibonacciModule;
using Calico.KillCalculatorModule;

namespace WitchSaga.BuilderExtensions;

public static class KillCalculatorWebAppBuilderExtensions
{
    public static void AddKillCalculator(this WebApplicationBuilder builder)
    {
        var fibonacciService = new MatrixExpFibonacciService(indexZero: 0, indexOne:1);
        builder.Services.AddSingleton<IFibonacciService>(fibonacciService);
        
        builder.Services.AddSingleton<IKillCalculator, KillCalculator>();
    }
}