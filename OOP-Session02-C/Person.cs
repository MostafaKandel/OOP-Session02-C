using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session02_C
{
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // constructor

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Methods
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
