namespace ExamKata;



class Classes
{
    class Player
    {
        private string name { get; set; }
        private int health; 
        private int Attack;
        private int heal;
        private int takeDamage;
    }

   class Enemy : Encounter
    {
        public override void Interact()
        {
            Console.WriteLine("You've encountered an enemy! What will you do?");
        }
        private string type;
        public int health { get; set; }
        public int Attack { get; set; }
        private int takeDamage;

        public Enemy()
        {
            health = 100;
            Attack = 30;
        }
    }

    class NPC : Encounter
    {
        private string Name { get; set; }

        public NPC()
        {
            Name = "NPC";
        }
        public override void Interact()
        {
            Console.WriteLine("Hello! Good luck on your journey!");
        }
        private string Dialogue;
    }

    class Merchant : Encounter
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
    

    abstract class Encounter
    {
        public abstract void Interact();
    }
    
}