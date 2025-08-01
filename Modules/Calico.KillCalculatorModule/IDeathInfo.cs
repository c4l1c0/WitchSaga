namespace Calico.KillCalculatorModule;

public interface IDeathInfo
{
    ushort AgeOfDeath { get; init; }
    
    uint YearOfDeath { get; init; }

    uint BirthYear { get; }
}