using System.Threading.Channels;

namespace ExamKata;

public class Game
{
    public void start()
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
                while (true)
                {
                    Random randomEncounter = new Random();
                    int EncounterType = randomEncounter.Next(0, 3);
                    if (EncounterType == 0)
                    {
                        Classes.Enemy enemy = new Classes.Enemy();
                        Console.WriteLine("You've encountered an enemy! What will you do?");
                        

                    }
                }

            }
        }
    }
}