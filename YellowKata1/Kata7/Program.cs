// See https://aka.ms/new-console-template for more information


static void attackEnemy(string action, Enemy enemy, int damage)
{
    int EnemyHealth = 100;
    int modifiedDamage = damage;
    if (EnemyHealth < 1)
    {
        Console.WriteLine($"{enemy.Race} is defeated!");
    }
    else
    {
        enemy.takeDamage(damage);
    }

    Console.WriteLine($"{action} {enemy.Race} and took {damage} damage! {enemy.Race} now has {enemy._enemyHealth}");
}

Player player = new();

Enemy enemy = new(300, "Golem");

attackEnemy("Attacked", enemy, damage: player.playerDamageDealt);

class Player
{
    private string playerName = "Hero";
    private int playerHealth = 300;
    private int playerLevel = 5;
    private int playerExperience = 345;
    public int playerDamageDealt = 50;
}

class Enemy
{
    private string type = "Orc";
    private int enemyHealth = 100;

    public Enemy(int health, string type)
    {
        _enemyHealth = health;
        Race = type;
    }

    public string Race
    {
        get;
    }

    public int _enemyHealth
    {
        get;
    }
    public void takeDamage(int damage)
    {
        enemyHealth -= damage;
    }
}


