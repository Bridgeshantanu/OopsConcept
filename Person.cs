using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Person
    {
        public string Name;
        public int Age;

        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
