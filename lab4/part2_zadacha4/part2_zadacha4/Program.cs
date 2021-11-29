using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade grade = new Grade();
            grade.gradesAndDisciplines = new Dictionary<string, int>();

            while(true)
            {
                Console.WriteLine("1.Discipline And Grade");
                Console.WriteLine("2. Print final grade");
                Console.WriteLine("3.Exit: ");

                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.WriteLine("Write discipline name: ");
                        String name = Console.ReadLine();

                        Console.WriteLine("Write grade points: ");
                        int points = Int32.Parse(Console.ReadLine());
                        grade.gradesAndDisciplines.Add(name, points);
                        
                        break;
                    case "2":
                        grade.printFinalGrade();
                        break;
                    case "3":
                        break;
                }
            }
        }
    }
}
