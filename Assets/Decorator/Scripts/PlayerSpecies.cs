public class PlayerSpecies : IPlayerStats
{
    public PlayerSpecies(IPlayerStats playerStats, Species species)
    {
        switch (species)
        {
            case Species.Human:
                Strenght = playerStats.Strenght;
                Strenght += 5;
                Agility = playerStats.Agility;
                Agility += 5;
                Intelligence = playerStats.Intelligence;
                Intelligence += 5;
                break;
            
            case Species.Elf:
                Strenght = playerStats.Strenght;
                Strenght += 2;
                Agility = playerStats.Agility;
                Agility += 10;
                Intelligence = playerStats.Intelligence;
                Intelligence += 2;
                break;
            
            case Species.Ork:
                Strenght = playerStats.Strenght;
                Strenght += 10;
                Agility = playerStats.Agility;
                Agility += 2;
                Intelligence = playerStats.Intelligence;
                Intelligence += 2;
                break;
        }
    }
    public int Strenght { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
}