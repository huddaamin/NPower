using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Circle : Shape//Java would be this class Circle extend Shape
    {
        public override void Draw() {
            Console.WriteLine("Drawing a Circle");
            base.Draw();
        }
    }
}
