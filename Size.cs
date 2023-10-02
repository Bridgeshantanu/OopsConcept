using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    abstract class Size
    {
        public abstract void Draw();
    }

    class Triangle: Size
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle.");
        }
    }

    class Rectangle : Size
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
