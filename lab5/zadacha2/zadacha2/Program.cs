using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Idimensions dimensions = new Box(2,3);
            Console.WriteLine("length: " + dimensions.Length() + " width: " + dimensions.Width());

            Box box = new Box(2, 3);
            Console.WriteLine("length: " + box.Length() + " width: " + box.Width());

            Console.ReadLine();
        }
    }
}
