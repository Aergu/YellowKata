// See https://aka.ms/new-console-template for more information


static void attackEnemy(string action, Enemy enemy, int damage)
{
    enemy.takeDamage(damage);
    Console.WriteLine($"{action} {enemy.type} and dealt {damage} damage! {enemy.type} now has {enemy._enemyHealth} health!");
    
    if (enemy._enemyHealth <= 0)
    {
        Console.WriteLine($"{enemy.type} is defeated!");
        Console.WriteLine($"Gained {enemy.GiveExp()} exp!");
    }
}

Player player = new();

Enemy enemy = new(250, "Golem");

while (enemy._enemyHealth > 0)
{
    attackEnemy("Attacked", enemy, damage: player.PlayerDamageDealt);
}

class Player
{
    private string playerName = "Hero";
    private int playerHealth = 300;
    private int playerLevel = 5;
    private int playerExperience = 345;
    public int PlayerDamageDealt = 50;
}

class Enemy
{
    public string type { get; set; }
    public int _enemyHealth { get; set; }

    private readonly int _maxHealth;

    public Enemy(int health, string enemyType)
    {
        _enemyHealth = health;
        _maxHealth = health;
        type = enemyType;
    }
    public void takeDamage(int damage)
    {
        _enemyHealth -= damage;
    }
    
    public int GiveExp()
    {
        return _maxHealth / 5;
    }
}


