using System.Numerics;
using Calico.KillCalculatorModule;
using Microsoft.AspNetCore.Mvc;

namespace Calico.WitchSaga.Controllers;

public class KillCalculatorController : Controller
{
    [HttpGet]
    public double Calculate(
        [FromServices] IKillCalculator calculator, 
        IDeathInfo[] deathInfos)
    {
        return calculator.GetAverageKills(deathInfos);
    }
}