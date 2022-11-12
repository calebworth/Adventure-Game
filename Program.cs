using BerserkerClass;
using System;


namespace GithubProject
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\"You have come to get your fortune told traveller!\"");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\"What is your name?\"");
            Console.ForegroundColor = ConsoleColor.White;
            string charactername = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\"Well {charactername}, in the future you'll have your crown stolen by two goblins!\"");
            System.Threading.Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"You turn around to see two goblins...");
            System.Threading.Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\"Get his crown!\"");
            System.Threading.Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Suddenly, the larger of the two jumps onto you.");
            Console.WriteLine($"The smaller one picks your crown from the ground and escapes through the entry with");
            Console.WriteLine($"his sidekick following him from behind.");
            System.Threading.Thread.Sleep(7000);
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a class:");
            Console.WriteLine("1) Berserker");
            Console.WriteLine("2) Mage");
            Console.WriteLine("3) Tank");
            Console.WriteLine("4) View class stats");
            Console.Write("\r\nSelect an option: ");

            

            switch (Console.ReadLine())
            {
                case "1":
                    Berserker.Stats();
                    return true;
                case "2":
                    
                    return true;
                case "3":

                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

       
    }
}     
       

/// Comments using "///"
/// Pull requests anytime baby!
/// <summary> Text-based adventure game</summary>


