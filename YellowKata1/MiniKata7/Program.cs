// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Player player = new("Hero", 100, 1);
Enemy enemy = new("Goblin", 50, 10);

Console.WriteLine($"Player Info: \nName: {player.Name} \nHealth: {player.Health} \nLevel: {player.Level} \n");
Console.WriteLine($"Enemy Info: \nType: {enemy.Type} \nHealth: {enemy.Health} \nDamage: {enemy.Damage}");

class Player
{
    public string Name
    {
        get;
    }

    public int Health
    {
        get;
    }

    public int Level
    {
        get;
        
    }

    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }
}

class Enemy
{
    public string Type
    {
        get;
    }

    public int Health
    {
        get;
        
    }

    public int Damage
    {
        get;
    }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;

    }
}


