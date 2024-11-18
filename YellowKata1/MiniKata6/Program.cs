// See https://aka.ms/new-console-template for more information

string[] enemies = {"Goblin", "Orc", "Troll"};

List<string> playerInventory = new() {"Sword", "Shield", "Potion"};

Console.WriteLine("Enemies:");
foreach (var enemy in enemies)
{
    Console.WriteLine(enemy);
}

Console.WriteLine("Player Inventory:");
foreach (var item in playerInventory)
{
    Console.WriteLine(item);
}
Console.WriteLine("Updated Inventory:");
playerInventory.Add("Helmet");
for (int i = 0; i < playerInventory.Count; i++)
{
    Console.WriteLine(playerInventory[i]);
}
