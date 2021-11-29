using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Person> people = new List<Person>();

            Person firstPerson = new Person("Иван", "Иванов", "Георгиев", 23, 75);
            Person secondPerson = new Person("Силвия", "Манолова", "Георгиева", 21, 52);
            Person thirdPerson = new Person("Станимир", "Михайлов", "Киров", 24, 82);
            Person fourthPerson = new Person("Мирела", "Кирова", "Георгиева", 28, 58);

            people.Add(firstPerson);
            people.Add(secondPerson);
            people.Add(thirdPerson);
            people.Add(fourthPerson);
            people.Sort();
            foreach(Person element in people)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
