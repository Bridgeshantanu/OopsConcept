using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Shape
    {
        public virtual void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    
    class Circle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("This is a circle.");
        }
    }

    class Square : Shape
    {
        public override void Display()
        {
            Console.WriteLine("This is a square.");
        }
    }
}

