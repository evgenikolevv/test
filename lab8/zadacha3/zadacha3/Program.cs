using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> table = new Dictionary<string,string>();
            table.Add("path","път");
            table.Add("folder","директория");
            table.Add("directory","директория");
            table.Add("file","Файл");

            foreach (KeyValuePair<string, string> pair in table)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.WriteLine("");

            if (table.ContainsKey("file"))
            {
                table.Remove("file");
                table.Add("file", "файл");
            }

            foreach (KeyValuePair<string, string> pair in table)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.WriteLine("");

            if (table.ContainsKey("path"))
            {
                table.Remove("path");
                table.Add("path", "икона");
            }

            if (!table.ContainsKey("icon"))
            {
                table.Add("icon", "икона");
            }

            foreach (KeyValuePair<string, string> pair in table)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.WriteLine("");
          

            if (!table.ContainsKey("drive"))
            {
                table.Add("drive", "драйв");
            }

            foreach (KeyValuePair<string, string> pair in table)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.WriteLine("");


            IDictionaryEnumerator myEnumerator = table.GetEnumerator();
            while(myEnumerator.MoveNext())
            {
                Console.WriteLine(myEnumerator.Key + " : " + myEnumerator.Value);
            }

            Console.WriteLine("");

            foreach (KeyValuePair<string, string> pair in table)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.WriteLine("");

            for(int i = 0; i < table.Count; i++)
            {
                Console.WriteLine(table.ElementAt(i).Key + " : " + table.ElementAt(i).Value);
            }


            Console.ReadLine();

        }
    }
}
