using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_zadacha4
{
    class Grade 
    {  
       public Dictionary<string, int> gradesAndDisciplines { get; set; }

      public void printFinalGrade()
        {
            int finalGrade = 0;
            List<int> points = new List<int>();
            String values = "";

            foreach (KeyValuePair<string,int> entry in gradesAndDisciplines)
            {
                finalGrade += entry.Value;
                points.Add(entry.Value);
            }

            if (gradesAndDisciplines.Count == 1)
            {
                foreach (KeyValuePair<string, int> entry in gradesAndDisciplines)
                {
                    finalGrade += entry.Value;
                }
            }
            
            int grade = finalGrade / 2;

            if (grade < 50)
            {
                foreach (int element in points)
                {
                    values += " " + element;
                }

                Console.WriteLine("Точките ти са: " + values + " , следователни не си отличник!");
                Console.WriteLine("Средният брой точки е под 89.");
            }
            else if (grade >= 50 && grade < 61)
            {
                foreach (int element in points)
                {
                    values += " " + element;
                }

                Console.WriteLine("Точките ти са: " + values + " , следователни не си отличник!");
                Console.WriteLine("Средният брой точки е под 89.");
            }
            else if (grade >= 61 && grade <= 74)
            {
                foreach (int element in points)
                {
                    values += " " + element;
                }

                Console.WriteLine("Точките ти са: " + values + " , следователни не си отличник!");
                Console.WriteLine("Средният брой точки е под 89.");
            }
            else if (grade >= 75 && grade <= 88)
            {
                foreach (int element in points)
                {
                    values += " " + element;
                }

                Console.WriteLine("Точките ти са: " + values + " , следователни не си отличник!");
                Console.WriteLine("Средният брой точки е под 89.");
            }
            else if (grade >= 89)
            {
                foreach (int element in points)
                {
                    values += " " + element;
                }

                Console.WriteLine("Точките ти са: " + values + " , следователни си отличник!");
            }
        }
    }
}
