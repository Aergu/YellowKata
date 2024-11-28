using System.IO.Pipes;
using System.Threading.Channels;

namespace ExamKata;

public class Game
{
    public void start()
    {
        
        string input = "";

        while (true)
        {
            Console.WriteLine("Enter your name and begin your journey!");
            input = Console.ReadLine();
            
            if (input == "")
            {
                Console.WriteLine("What!? Try again chump!");
                continue;
            }

            break;
        }
        
        Player player = new Player(input, 200, 50);

        while (player.Health > 0)
        {
            Random randomEncounter = new Random();
            int EncounterType = randomEncounter.Next(0, 3);

            switch (EncounterType)
            {
                case 0:
                    EnemyEncounter(player);
                    break;
                case 1:
                    NPC npc = new NPC();
                    npc.Interact();
                    break;
                case 2:
                    Merchant merchant = new Merchant();
                    merchant.Interact();
                    break;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        Console.WriteLine("Game over!");
    }

    private void EnemyEncounter(Player player)
    {
        Enemy enemy = new ("Goblin", 100, 30);
        Console.WriteLine("You've encountered an enemy! What will you do?");
        Console.WriteLine("1. Fight " + "2. Run");
        string input = Console.ReadLine();

        if (input == "Run")
        {
        Console.WriteLine("You've escaped!");
            return;
        }

        while (player.Health > 0 && enemy.Health > 0)
        {
            
            Console.WriteLine("1. Attack" + " 2. Heal");
            string fightInput = Console.ReadLine();

            if (fightInput == "1" || fightInput == "Attack")
            {
                Console.WriteLine($"{player.Name} attacked {enemy.Type} and dealt {player.Attack} damage!");
                player.AttackEnemy(enemy: enemy, damage: 50);
                enemy.AttackPlayer(player);
                Console.WriteLine($"{enemy.Type} attacked {player.Name} and dealt {enemy.Attack} damage!");
                Console.WriteLine($"Enemy's health is {enemy.Health}.");
                Console.WriteLine($"Players health is {player.Health}.");
            }
            else if (fightInput == "2" || fightInput == "Heal")
            {
                int healAmount = 50;
                player.HealPlayer(healAmount);
                Console.WriteLine($"{player.Name} healed {healAmount} health!");
            }
        }
    }
}