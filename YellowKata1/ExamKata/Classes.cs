namespace ExamKata;

public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int Attack { get; }
    private int heal;
    private int takeDamage;

    public Player(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }
    
    public void AttackEnemy(Enemy enemy, int damage)
    {
        int damagedealt = damage;
        enemy.TakeDamage(damagedealt);
    }
    
    public void HealPlayer(int healAmount)
    {
        Health += healAmount;

    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}

   public class Enemy : Interactable
    {
        public override void Interact()
        {
        }
        public int Health { get; set; }
        public int Attack { get; }
        public string Type { get; }
        
        public Enemy(string type, int health, int attack)
        {
            Type = type;
            Health = health;
            Attack = attack;
        }
        
        public void AttackPlayer(Player player)
        {
            player.TakeDamage(Attack);
        }
        
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    class NPC : Interactable
    {
        private string Name { get; set; }

        public NPC()
        {
            Name = "NPC";
        }
        public override void Interact()
        {
            Console.WriteLine($"Hello! Good luck on your journey!");
        }
        private string Dialogue;
    }

    class Merchant : Interactable
    {
        public List<string> Inventory { get; set; }

        public Merchant()
        {
            Inventory = new List<string> { "Potion", "Sword", "Shield" };
        }
        public override void Interact()
        {
            Console.WriteLine("Welcome traveler! Would you like to take a look at my wares?");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item}");
            }
        }
        private string Dialogue;
        private string Trade;
        
    }

    public abstract class Interactable
    {
        public abstract void Interact();
    }
    
