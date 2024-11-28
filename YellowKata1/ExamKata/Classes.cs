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
        private int health;
        private int TakeDamage;
    }

    class NPC : ISpeaker
    {
        public void Speak()
        {
            Console.WriteLine("Hello! Good luck on your journey!");
        }
        private string Dialogue;
    }

    class Merchant : ISpeaker
    {
        public void Speak()
        {
            Console.WriteLine("Welcome traveler! Would you like to take a look at my wares?");
        }
        private string Dialogue;
        private string Trade;
        
    }

    interface ISpeaker
    {
        void Speak();
    }

    abstract class Encounter
    {
        public abstract void Interact();
    }
    
}