// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

string [] enemies = {"Goblin", "Orc", "Troll", "Skeleton", "Dragon"};

List<string> playerInventory = new() { "Sword", "Shield", "Potion" };

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

playerInventory.Add("Helmet");
playerInventory.Add("Armor");
playerInventory.Remove("Potion");
Console.WriteLine("Updated Inventory:");
foreach (var item in playerInventory)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Total items in Inventory: {playerInventory.Count}");


