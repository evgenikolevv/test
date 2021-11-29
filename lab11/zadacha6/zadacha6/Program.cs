using System;
using System.IO;
namespace directoryLister
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Задай директория от която да се изведат файлове : ");
            string directory = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(directory);
            foreach (FileInfo f in dir.GetFiles("*.*", SearchOption.AllDirectories))
            {
                string name = f.FullName;
                long size = f.Length;
                DateTime t = f.CreationTime;
                Console.WriteLine("{0},\n{1}, {2:g}", name, size, t);
            }

            Console.ReadLine();

        }
    }
}