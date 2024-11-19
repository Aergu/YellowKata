Player player = new(400, 5, 60);

int minLevel = 0;

class Player
{
    // private int health = 400;
    // private int level = 5;
    // private int experience = 50;

    
    public Player (int health, int level, int experience)
    {
        _health = health;
        _level = level;
        _exp = experience;
    }

    private int _health { get; set; }

    private int _level
    {
        get;
    }

    private int _exp
    {
        get;
    }
}
