using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterAddTwoNumbersConsoleApp
{
    class Program
    {
        //global variables
        static int number1;
        static int number2;

        //constructor to create two variables for every object
        public Program(int x, int y) {
            number1 = x;
            number2 = y;
        }
        //Function that takes two values from the object and adds them together
        public int add2numbers() {
            return (number1 + number2);
        }
        static void Main(string[] args) //the start or key to beginning your program
        {
            Program values = new Program(3, 5); //created an object using the "new" keyword

            int result = values.add2numbers(); //integer that stored a function/method
            Console.WriteLine("\n The result of" + number1 + number2+"is" + result);
            Console.ReadLine();//stops the console from closing
        }
    }
}
