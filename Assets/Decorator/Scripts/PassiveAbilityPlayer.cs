public class PassiveAbilityPlayer : IPlayerStats
{
    public PassiveAbilityPlayer(IPlayerStats playerStats, PassiveAbility passiveAbility)
    {
        switch (passiveAbility)
        {
            case PassiveAbility.Erudite:
                Strenght = playerStats.Strenght;
                Agility = playerStats.Agility;
                Intelligence = playerStats.Intelligence;
                Intelligence = 2;
                break;
            
            case PassiveAbility.HotBlood:
                Strenght = playerStats.Strenght;
                Strenght *= 3;
                Agility = playerStats.Agility;
                Agility -= 2;
                Intelligence = playerStats.Intelligence;
                break;
            
            case PassiveAbility.Skinny:
                Strenght = playerStats.Strenght;
                Strenght -= 4;
                Agility = playerStats.Agility;
                Agility *= 2;
                Intelligence = playerStats.Intelligence;
                break;
        }       
    }
    public int Strenght { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
}