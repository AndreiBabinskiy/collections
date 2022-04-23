using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    class Pet : IComparable
    {
        private string name;
        private int age;

        public Pet() : this("Noname", 4)
        {

        }

        public Pet(string name) : this(name, 10)
        {
            
        }

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public int CompareTo(object other)
        {
            return this.name.CompareTo((other as Pet)?.Name ?? "");
        }

        public override bool Equals(object obj)
        {
            return ((obj as Pet)?.Name ?? "") == name;
        }

        public override string ToString()
        {
            return $"Питомец {Name}, {Age} лет";
        }
    }
}
