using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private int Gender { get; set; }

        public Person(string name, int age, int gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"{Name}. {Age}. {Gender}.";
        }

    }
}
