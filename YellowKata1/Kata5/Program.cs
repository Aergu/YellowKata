namespace Kata5;

class Enemy
{
    public int health
    {
        get;
        private set;
    }
    public Enemy(int health, string name, string race)
    {
        _health = health;
        Race = race;
        Name = name;
    }
    private int _health = 100;

    public string Name
    {
        get;
        
    }

    public string Race
    {
        get;
        set;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }



}

class Player
{
    public int damage = 30;
    
}
class Program
{
            static void AttackEnemy(string action, Enemy enemy, int damage)
            {
                Random random = new();
                int result = random.Next(0, 10);
                int modifiedDamage = damage;
                if (result < 5)
                {
                    modifiedDamage *= 2;
                    enemy.TakeDamage(modifiedDamage);
                    Console.WriteLine("Critical hit!");
                }
                else
                {
                enemy.TakeDamage(modifiedDamage); 
                }
                Console.WriteLine($"{action} {enemy.Name} and dealt {modifiedDamage} damage! {enemy.Name} now has {enemy.health} health!");
            }
            static void HealPlayer(string playerName, int healAmount)
            {
                playerName = "Arin";
                healAmount = 15;
        
                Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
            }
    static void Main(string[] args)
    {
        Player player = new();
        player.damage = 50;

        Player player2 = new();
        
        Enemy enemy = new(300, "Golem", "Human" );
        
        AttackEnemy("Spell cast on", enemy, damage: player2.damage);

        Enemy enemy2 = new(1500, "Infernus", "Dragon");
        enemy2.Race = "Dragon";

    }
}