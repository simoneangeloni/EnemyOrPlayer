using BlaisePascal.EnemyOrPlayer.Domain;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        try
        {
            Enemy enemy = new Enemy("Goblin", 100, 25);

            Console.WriteLine(enemy);

            Console.WriteLine($"Is the enemy alive? {enemy.IsAlive()}");

            enemy.TakeDamage(30);

            Console.WriteLine($"Is the enemy alive? {enemy.IsAlive()}");

            Console.WriteLine("Insert player's name");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);
            Console.WriteLine($"the name of your player is {player.Name}");

             player.GainExperience(150);
            int experience = player.Experience;

            Console.WriteLine($"Experience after gain: {experience}");

            player.AddGold(50);
            Console.WriteLine($"Player's gold: {player.Gold}");

            player.TakeDamage(30);

            player.Heal(20);

            player.TakeDamage(100);

            Console.WriteLine($"Is the player alive? {player.IsAlive}");

            player.ResetHealth();

            player.ResetExperience();
            Console.WriteLine($"Player's experience after reset: {player.Experience}");
            Console.WriteLine($"Player's health after reset: {player.Health}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");

        }
    }

        }


