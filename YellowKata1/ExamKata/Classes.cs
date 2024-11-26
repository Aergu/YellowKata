namespace ExamKata;

class Classes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    class Player
    {
        private string name;
        private int health;
        private int Attack;
        private int heal;
    }

    class Enemy
    {
        private string type;
        private int health;
        private int TakeDamage;
    }

    class NPC
    {
        private string Dialogue;
    }

    class Merchant
    {
        private string Dialogue;
        private string Trade;
    }
    
}