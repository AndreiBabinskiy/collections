using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    class Bird : Pet, IFlying
    {
        public Bird(string name, int age) : base(name, age)
        {

        }
        public void Fly()
        {
            Console.WriteLine("Птичка " + Name + " летит ");
        }
    }
}
