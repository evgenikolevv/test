using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
         const string name = "test.txt";
        static void Main()
        {
            if (File.Exists(name))
            {
                Console.WriteLine("Файл с име {0} съществува!", name);
                StreamReader streamReader = new StreamReader(name);
                string input;
                while ((input = streamReader.ReadLine()) != null)
                    Console.WriteLine(input);

                Console.ReadLine();
                return;
            }
            else 
            {   
                StreamWriter sw = File.CreateText(name);
                Console.WriteLine("Въведете име");
                string names = Console.ReadLine();
                Console.WriteLine("Въведете година");
                string year = Console.ReadLine();
                Console.WriteLine("Въведете град");
                string city = Console.ReadLine();
                sw.WriteLine("{0},{1},{2}", names, year, city);
                sw.Close();
                Console.WriteLine("Файл с име  {0} е създаден!!!", name);
                Console.ReadKey();
            }
        }

    }
}
