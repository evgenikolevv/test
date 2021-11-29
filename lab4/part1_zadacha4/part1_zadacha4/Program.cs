using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1_zadacha4
{
    class Program
    {
        private static void createAuto()
        {
            IAuto auto = new IAuto();

            Console.WriteLine("Двигател :");
            auto.Dvigatel = Console.ReadLine();
            
            Console.WriteLine("Скорост :");
            auto.Skorost = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Цвят :");
            auto.Color = Console.ReadLine();
            
            Console.WriteLine("Път параметър :");
            double distance = Double.Parse(Console.ReadLine());
            double path = auto.calculateTime(distance);
            Console.WriteLine(path);

            Console.WriteLine(auto.ToString());
        }

        private static void createAutoSport()
        {
            Sport_Auto auto = new Sport_Auto();

            Console.WriteLine("Двигател :");
            auto.Dvigatel = Console.ReadLine();

            Console.WriteLine("Скорост :");
            auto.Skorost = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Цвят :");
            auto.Color = Console.ReadLine();

            Console.WriteLine("Път параметър :");
            double distance = Double.Parse(Console.ReadLine());
            double path = auto.calculateTime(distance);
            Console.WriteLine(path);

            Console.WriteLine("Nos (true/false) :");
            string input = Console.ReadLine();
            if (input.Equals("true"))
            {
                auto.Nos = true;
            }
            else if (input.Equals("false")) 
            {
                auto.Nos = false;
            }

            Console.WriteLine("Spoiler (true/false) :");
            string spoiler = Console.ReadLine();
            if (input.Equals("true"))
            {
                auto.Spoiler = true;
            }
            else if (input.Equals("false"))
            {
                auto.Spoiler = false;
            }

            Console.WriteLine(auto.ToString());
        }

        private static void createTruck()
        {
            Track auto = new Track();

            Console.WriteLine("Двигател :");
            auto.Dvigatel = Console.ReadLine();

            Console.WriteLine("Скорост :");
            auto.Skorost = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Цвят :");
            auto.Color = Console.ReadLine();

            Console.WriteLine("Път параметър :");
            double distance = Double.Parse(Console.ReadLine());
            double path = auto.calculateTime(distance);
            Console.WriteLine(path);

            Console.WriteLine("Weight: ");
            auto.Weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Height: ");
            auto.Height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            auto.Width = Double.Parse(Console.ReadLine());

            Console.WriteLine("Потенциал: ");
            auto.Potencial = Double.Parse(Console.ReadLine());


            Console.WriteLine(auto.ToString());
        }


        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1.Изберете Auto");
                Console.WriteLine("1.Изберете Sport_Auto");
                Console.WriteLine("1.Изберете Truck");
                Console.WriteLine("4.Изход");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        createAuto();
                        break;
                    case "2":
                        createAutoSport();
                        break;
                    case "3":
                        createTruck();
                        break;
                    case "4":
                        return;
                }
            }
        }
    }
}
