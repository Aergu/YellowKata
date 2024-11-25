Player player = new(400, 5, 60);
player.Level = 1;
int minLevel = 0;

while (player.Level < 2)
{
    int gainedExp = 10;
    player.GainExp(gainedExp);
    Console.WriteLine($"{player} gains {gainedExp} experience points.");
    Console.WriteLine($"The Players level is {player.Level} and has {player.Exp} experience points.");
}



public class Player
{
    
    public Player (int health, int level, int experience)
    {
        _health = health;
        _level = level;
        _exp = experience;
    }

    private int _health { get; set; }

    private int _level;

    private int _exp;
    

    public int Level
    {
        get { return _level; }
        set
        {
            _level = Math.Max(value, 0);
        }
    }

    public void GainExp(int amountExp)
    {
        Exp += amountExp;

        if (Exp > 100)
        { 
            Exp -= 100;
            Level++;
            Console.WriteLine("You have leveled up!");
        }

        
    }
    public int Exp
    {
        get { return _exp; }
        private set
        {
            _exp = Math.Max(value, 0);
        }
    }

}


