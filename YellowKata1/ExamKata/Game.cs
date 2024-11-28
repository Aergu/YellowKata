using System.IO.Pipes;
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

                    Encounter encounter;
                    switch (EncounterType)
                    {
                        case 1:
                            encounter = new Enemy();
                            break;
                        case 2:
                            encounter = new NPC();
                            break;
                        case 3:
                            encounter = new Merchant();
                            break;
                    }
                    if (encounter != null)
                    {
                        encounter.Interact();
                    }
                }

            }
        }
    }
}