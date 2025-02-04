using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    public class Fish : Animal
    {
        public Fish(string name, int age) : base(name, age) 
        {
        }
        public override void MakeSound()
        {
            //Fish don't make sounds
            Console.WriteLine($"{Name} doesn't make sound.");
        }
    }
}
