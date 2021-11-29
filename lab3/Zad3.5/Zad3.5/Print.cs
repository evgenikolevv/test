using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3._5
{
    class Print
    {
        public static void print()
        {
            while (true)
            {
                Console.WriteLine("Please enter the number of month  (Enter 0 to exit!)");
                int month = Int32.Parse(Console.ReadLine());
                Convert(month);
            
            }
        }

        private static void Convert(int month)
        {
            switch (month) 
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine(Months.January);
                    break;
                case 2:
                    Console.WriteLine(Months.February);
                    break;
                case 3:
                    Console.WriteLine(Months.March);
                    break;
                case 4:
                    Console.WriteLine(Months.April);
                    break;
                case 5:
                    Console.WriteLine(Months.May);
                    break;
                case 6:
                    Console.WriteLine(Months.June);
                    break;
                case 7:
                    Console.WriteLine(Months.July);
                    break;
                case 8:
                    Console.WriteLine(Months.August);
                    break;
                case 9:
                    Console.WriteLine(Months.September);
                    break;
                case 10:
                    Console.WriteLine(Months.October);
                    break;
                case 11:
                    Console.WriteLine(Months.November);
                    break;
                case 12:
                    Console.WriteLine(Months.December);
                    break;
                default:
                    Console.WriteLine("the number must be between 1-12!");
                    break;
            }
            
        }
    }
}
