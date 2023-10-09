public class PlayerSpecialization : IPlayerStats
{
    public PlayerSpecialization(IPlayerStats playerStats, Specializations specializations)
    {
        switch (specializations)
        {
            case Specializations.Barbarian:
                Strenght = playerStats.Strenght;
                Strenght += 10;
                Agility = playerStats.Agility;
                Agility -= 7;
                Intelligence = playerStats.Intelligence;
                Intelligence = 2;
                break;
            
            case Specializations.Thief:
                Strenght = playerStats.Strenght;
                Strenght -= 5;
                Agility = playerStats.Agility;
                Agility += 10;
                Intelligence = playerStats.Intelligence;
                Intelligence += 5;
                break;
            
            case Specializations.Wizard:
                Strenght = playerStats.Strenght;
                Strenght -= 7;
                Agility = playerStats.Agility;
                Intelligence = playerStats.Intelligence;
                Intelligence *= 2;
                break;
        }
    }
    public int Strenght { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
}