namespace Calico.KillCalculatorModule;

public class DeathInfo : IDeathInfo
{
    public DeathInfo(ushort ageOfDeath, uint yearOfDeath)
    {
        AgeOfDeath = ageOfDeath;
        YearOfDeath = yearOfDeath;
    }
    
    public ushort AgeOfDeath { get; init; }
    
    public uint YearOfDeath { get; init; }
    
    public uint BirthYear => YearOfDeath - AgeOfDeath;
}