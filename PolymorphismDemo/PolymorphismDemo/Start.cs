using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Start
    {
        static void Main(string[] args)
        {
            Shape s = new Circle();
            s.Draw();
            Console.ReadLine();
        }
    }
}
