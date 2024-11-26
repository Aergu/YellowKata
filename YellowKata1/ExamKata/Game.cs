using System.Threading.Channels;

namespace ExamKata;

public class Game
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name and begin your journey!");
        string input = Console.ReadLine();
        while (true)
        {
            if (input == "")
            {
                Console.WriteLine("What!? Try again chump!");
                break;
            }
            else
            {
                new Random(1,11)
                    
            }
        }
    }
}