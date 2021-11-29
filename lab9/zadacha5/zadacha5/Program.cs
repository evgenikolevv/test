using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    class Program
    {
        static SortedList<string, string> getData() 
        {
            SortedList<string, string> pairs = new SortedList<string, string>();
            pairs.Add("17621785", "Иван Иванов");
            pairs.Add("17621775", "Стоян Христов");
            pairs.Add("17521665", "Мария Стоянова");
            pairs.Add("17721633", "Мирела Георгиева");
            pairs.Add("17721663", "Кирил Маринов");
            return pairs;
        }
        static void Main(string[] args)
        {
            SortedList<string, string> pairs = getData();

            while(true)
            {
                Console.WriteLine("1.Print all records.");
                Console.WriteLine("2.Search by key and value");
                Console.WriteLine("3.Remove by key.");
                Console.WriteLine("4.Quit");
                String input = Console.ReadLine();

                if (input.Equals("4"))
                {
                    break;
                } 
                else if (input.Equals("1"))
                {
                    foreach (KeyValuePair<string, string> entry in pairs)
                    {
                        Console.WriteLine(entry.Key + " " + entry.Value);
                    }
                }
                else if (input.Equals("2"))
                {
                    Console.WriteLine("Enter key: ");
                    string key = Console.ReadLine();
                    Console.WriteLine("Enter value: ");
                    string value = Console.ReadLine();
                    pairs.IndexOfKey(key);
                    foreach (KeyValuePair<string, string> entry in pairs)
                    {
                        if (entry.Key.Equals(key) && entry.Value.Equals(value))
                        {
                            Console.WriteLine(entry.Key + " " + entry.Value);
                            break;
                        }
                    }
                }
                else if (input.Equals("3"))
                {
                    Console.WriteLine("Enter key:");
                    string key = Console.ReadLine();
                    pairs.Remove(key);
                }   
            }

            Console.ReadLine();
        }
    }
}
