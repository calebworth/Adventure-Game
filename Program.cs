using BerserkerClass;
using System;


namespace GithubProject
{

    public class Program
    {
        static void Main(string[] args)
        {                      

            Console.WriteLine("You have come to get your fortune told traveller!");
            Console.WriteLine("What is your name?");
            string charactername = Console.ReadLine();
            Console.WriteLine($"Welcome {charactername}, your crown was stolen!");
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


