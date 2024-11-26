using System.Threading.Channels;

namespace Kata10;

class Program
{
    static void Main(string[] args)
    {
        Player player = new(200, "Hero", 50);
        Enemy enemy = new(100, "Goblin", 20);
        NPC npc = new("Jack", "Welcome to our Village!");
        Merchant merchant = new("Tom");
        player.Attack(enemy);
        Console.WriteLine($"{player.Name} attacks {enemy.Type} and deals {player.AttackDamage} damage.");
        Console.WriteLine($"{enemy.Type} takes {player.AttackDamage} damage. Remaining health: {enemy.Health}");
        Console.WriteLine($"{npc.Name} says: {npc.Dialogue}");
        Console.WriteLine($"{merchant.Name}'s inventory:");
        merchant.InventoryList();

        ISpeaker Mspeak = new MerchantSpeak();
        ISpeaker _speak = new NPCSpeak();
        
    }

    class Player
    {
        public string Name { get; }
        public int Health { get; private set; }
        public int Level { get; }
        public int AttackDamage { get; }

        public Player (int health, string name, int Attack)
        {
            Health = health;
            Name = name;
            AttackDamage = Attack;
        }

        public void Attack(Enemy enemy)
        {
            enemy.TakeDamage(AttackDamage);
        }
    }

    class Enemy
    {
        public string Type;
        public int Health { get; private set; }
        private int Damage;

        public Enemy(int health, string type, int damage)
        {
            Health = health;
            Type = type;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    class NPC
    {
        public string Name { get; private set; }
        public string Dialogue { get; private set; }

        public NPC(string name, string dialogue)
        {
            Name = name;
            Dialogue = dialogue;
        }
        
    }

    interface IMerchantInventory
    {
        void InventoryList();
    }

    
    class Merchant : IMerchantInventory 
    {
        
        public void InventoryList()
        {
            Console.WriteLine("Sword, Shield, Potion");
        }

        public void Speak()
        {
            Console.WriteLine("I'm ready to trade!");
        }
        public string Name { get; private set; }

        public List<string> inventory = new List<string>();
        public string Trade { get; private set; }

        public Merchant(string name)
        {
            Name = name;
            List<string>Inventory = inventory;
            
        }

        private string merchantName;
        List<string> _inventory;
    }

    interface ISpeaker
    {
        void Speak();
    }

    class MerchantSpeak : ISpeaker
    {
        public void Speak()
        {
            Console.WriteLine("I'm ready to trade!");
        }
    }

    class NPCSpeak : ISpeaker
    {
        public void Speak()
        {
            Console.WriteLine("Welcome to our village!");
        }
    }
   
}