using System;
using System.IO;
namespace file
{
    struct president
    {
        public string ime;
        public string uspeh;
    }

    class Program
    {
        private const string name = "test2.txt";
        
        static void Main()
        {
            if (File.Exists(name))
            {
                Console.WriteLine("Файлът съществува.");

                String line;
                try
                {
                    StreamReader sr = new StreamReader("test2.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }

                    sr.Close();

                    StreamWriter streamWriter = new StreamWriter("test2.txt", true);
                    Console.WriteLine("Въведете 3 студента.");
                    president p;

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Въведи име:");
                        p.ime = Console.ReadLine();
                        Console.WriteLine("Въведи успех:");
                        p.uspeh = Console.ReadLine();

                        streamWriter.WriteLine(p.ime + " " + p.uspeh);
                    }

                    streamWriter.Close();
                    Console.ReadLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
            else
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter("test2.txt", true);
                    Console.WriteLine("Въведете 3 студента.");
                    president p;

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Въведи име:");
                        p.ime = Console.ReadLine();
                        Console.WriteLine("Въведи успех:");
                        p.uspeh = Console.ReadLine();

                        streamWriter.WriteLine(p.ime + " " + p.uspeh);
                    }

                    streamWriter.Close();
                    Console.ReadLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
            Console.ReadKey();
        }
    }
}

