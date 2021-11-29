using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {   

        private static void createTeacher()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Creating Teacher.");

            Console.WriteLine("Specialty:");
            teacher.Specialty = Console.ReadLine();

            Console.WriteLine("Degree:");
            teacher.Degree = Console.ReadLine();

            Console.WriteLine("Predmet:");
            teacher.Predmet = Console.ReadLine();

            Console.WriteLine("Field:");
            teacher.Field = Console.ReadLine();

            Console.WriteLine("Klas:");
            teacher.Klas = Console.ReadLine();

            Console.WriteLine("Stavka:");
            teacher.Stavka = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Chasove: ");
            int hours = Int32.Parse(Console.ReadLine());
            Console.WriteLine(teacher.calculate(hours));

            Console.WriteLine(teacher);
        }

        private static void createDoctor()
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Creating Teacher.");

            Console.WriteLine("Specialty:");
            doctor.Specialty = Console.ReadLine();

            Console.WriteLine("Degree:");
            doctor.Degree = Console.ReadLine();

            Console.WriteLine("Ambolatoren List (Pacient):");
            doctor.AmbolatorenList = Console.ReadLine();

            Console.WriteLine("Field:");
            doctor.Field = Console.ReadLine();

            Console.WriteLine("Recepta:");
            doctor.Recepta = Console.ReadLine();

            Console.WriteLine("Stavka:");
            doctor.Stavka = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Chasove: ");
            int hours = Int32.Parse(Console.ReadLine());
            Console.WriteLine(doctor.calculate(hours));

            Console.WriteLine(doctor);
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1.Teacher");
                Console.WriteLine("2.Doctor");
                Console.WriteLine("3.Exit");
                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        createTeacher();
                        break;
                    case "2":
                        createDoctor();
                        break;
                    case "3":
                        return;
                }
            }
        }
    }
}
