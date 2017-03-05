using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLoopy
{
    class Program
    {
        
            public class text
        {
            public static void pop()
            {
                Console.WriteLine(" Menu of Planets ");
                Console.WriteLine(" ==== == ======= ");
                Console.WriteLine("1. Jupiter 2. Mars 3. Mercury");
                Console.WriteLine("4. Neptune 5. Pluto 6. Saturn ");
                Console.WriteLine("7. Uranus 8.Venus 9. <Quit> ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int inputPlanet;
            double inputWeight;
            string planet;
            double weight;
            int Menu = 0;
            text.pop();
            // TODO: Input validation/loop
            Console.WriteLine("Enter your menu selection:");
            int.TryParse(Console.ReadLine(), out inputPlanet);
            Console.WriteLine();
            // TODO: Input validation/loop
            Console.WriteLine("Enter your weight on earth:");
            double.TryParse(Console.ReadLine(), out inputWeight);
            Console.WriteLine();
            // Use switch statements to set planet and weight based on the user's input
            switch (inputPlanet)
            {
                case 1:
                    planet = "Jupiter";
                    weight = inputWeight * 2.64;
                    break;
                case 2:
                    planet = "Mars";
                    weight = inputWeight * 0.38;
                    break;
                case 3:
                    planet = "Mercury";
                    weight = inputWeight * 0.37;
                    break;
                case 4:
                    planet = "Neptune";
                    weight = inputWeight * 1.12;
                    break;
                case 5:
                    planet = "Pluto";
                    weight = inputWeight * 0.04;
                    break;
                case 6:
                    planet = "Saturn";
                    weight = inputWeight * 1.15;
                    break;
                case 7:
                    planet = "Uranus";
                    weight = inputWeight * 1.15;
                    break;
                case 8:
                    planet = "Venus";
                    weight = inputWeight * 0.88;
                    break;
                case 9:
                    bye.end();
                    System.Threading.Thread.Sleep(1000); // pauses the system for 1 second
                    Environment.Exit(0); // closes the app
                    break;
                default:
                    break;
            }
            /*// Provide user with a result, based on their input
            Console.WriteLine(String.Format("Your weight of: {0} lbs would be {1} lbs on
            {2}.", inputWeight, weight, planet));
            Console.WriteLine();*/
            Console.Read();
        }
        /* catch (System.FormatException e)
        {
        Console.WriteLine("Please enter an integer between 1-9 for menu choice or a float
        for your weight on Earth.");
        }
        }*/
        // Closing Statement, Author's CodeName, and a farewell
        public class bye
        {
            public static void end()
            {
                Console.WriteLine("|--------------------------------------------------------------------------------|");
                
                
Console.WriteLine("----------------------------| |----------------------------");
Console.WriteLine(" |------------Goodbye!----------| ");
Console.WriteLine();
// Keep the console window open (only for debug)
Console.WriteLine("Press any key to exit.");
        }
    }
}
    }
