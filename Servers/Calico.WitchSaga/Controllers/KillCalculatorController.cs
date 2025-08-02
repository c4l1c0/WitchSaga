using Calico.KillCalculatorModule;
using Microsoft.AspNetCore.Mvc;

namespace Calico.WitchSaga.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]

public class KillCalculatorController : ControllerBase
{
    [HttpPost]
    public double Calculate(
        [FromServices] IKillCalculator calculator, 
        [FromBody] DeathInfo[] deathInfos)
    {
        return calculator.GetAverageKills(deathInfos);
    }
}