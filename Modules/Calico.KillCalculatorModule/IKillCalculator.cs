using System.Numerics;

namespace Calico.KillCalculatorModule;

public interface IKillCalculator
{
    double GetAverageKills(IDeathInfo[] deathInfos);
}