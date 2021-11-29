using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
       
        public static int Main()
        {
            //Създава един WordCounter object 
            WordCounter wc = new WordCounter();
            Int64 NumWords, NumChars;
            // Изчисления за тестовия стринг
            Console.WriteLine("\n1.Izvikvane na CountStats(out NumWords, out NumChars)");
            string input = Console.ReadLine();
            wc.CountStats(out NumWords, out NumChars, input);
            // Отпечатва резултатите
            Console.WriteLine("\n2.");

            Console.WriteLine("For string\n {0}", wc.Text);
            // Отпечатва table header
            Console.WriteLine("\n3.");

            Console.WriteLine("\n\nWords\tChars");
            Console.WriteLine("{0,5}\t{1,5}", NumWords, NumChars);

            Console.ReadLine();
            return 0;
        }
    }
}

