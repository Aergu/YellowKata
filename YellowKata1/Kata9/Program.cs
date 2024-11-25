namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Player player = new(200, "Hero", 50);
    }

    class Player
    {
        private string name;
        private int health;
        private int level;
        private int Attack;

        public Player (int health, string name, int Attack)
        {
            _health = health;
            _name = name;
            _Attack = Attack;
        }

        private int _health { get; set; }
        private int _name;
        private int _Attack;
    }

    class Enemy
    {
        private string type;
        private int health;
        private int damage;
    }

    class NPC
    {
        private string name;
        private string Dialogue;
    }

    class Merchant
    {
        private string name;
        List <string> inventory = new List<string>()
        {
            
        }
        private string Trade;
    }
}