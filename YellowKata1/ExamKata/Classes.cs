namespace ExamKata;



class Classes
{
    class Player
    {
        private string name { get; }
        private int health; 
        private int Attack;
        private int heal;
        public int IDnumber = 1;
    }

   class Enemy
    {
        private string type;
        private int health;
        private int TakeDamage;
        public int IDnumber = 2;
    }

    class NPC : ISpeaker
    {
        public void Speak()
        {
            Console.WriteLine("Hello! Good luck on your journey!");
        }
        private string Dialogue;
        public int IDnumber = 3;
    }

    class Merchant : ISpeaker
    {
        public void Speak()
        {
            Console.WriteLine("Welcome traveler! Would you like to take a look at my wares?");
        }
        private string Dialogue;
        private string Trade;

        public int IDnumber = 4;
    }

    interface ISpeaker
    {
        void Speak();
    }
    
}