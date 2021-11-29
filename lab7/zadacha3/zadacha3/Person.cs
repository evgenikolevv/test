using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Kilograms { get; set; }

        public Person(string name, string surname, string lastname, int age, int kilograms)
        {
            Name = name;
            Surname = surname;
            Lastname = lastname;
            Age = age;
            Kilograms = kilograms;
        }

        public int CompareTo(Person other)
        {
            if (this.Age > other.Age) 
            {
                return 1;
            } else if (this.Age < other.Age)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Surname: " + Surname + " Lastname: " + Lastname + " Age: " + Age + " Kilograms: " + Kilograms;
        }
    }
}
