Player player = new(400, 5, 60);
player.Level = -1000;
int minLevel = 0;

public class Player
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

    private int _level;

    public int Level
    {
        get { return _level; }
        set
        {
            _level = Math.Max(value, 0);
        }
    }

    private int _exp
    {
        get;
    }
    
    
}
