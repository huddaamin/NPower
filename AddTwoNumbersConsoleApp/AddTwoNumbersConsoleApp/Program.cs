//Libraries aka packages
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersConsoleApp//Projectname, a folder, container
{
    class Program//Name of your class
    {
        static void Main(string[] args)//Starting point for a program
        {
            int x;//stored on the stack
            int y;
            int result;
            Console.Write("\n Enter the first number to be added:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter the second number to be added:");
            y = Convert.ToInt32(Console.ReadLine());

            result = x + y;
            Console.Write("\n The result is:" + result);
            Console.ReadLine();//Pauses the Console so you can see result
        }
    }
}
