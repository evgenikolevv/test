using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3.Test_abstract
{
    class Geometry
    {
        static void Main(string[] args)
        {
            Square square = new Square(4,4);
            Rectangle rectangle = new Rectangle(4, 5);

            Console.WriteLine("Square characteristics");
            Console.WriteLine("Name: " + square.Name);
            Console.WriteLine("Description: " + square.Describe());

            Console.WriteLine("");

            Console.WriteLine("Rectangle characteristics");
            Console.WriteLine("Name: " + rectangle.Name);
            Console.WriteLine("Description: " + rectangle.Describe());
            Console.ReadLine();
        }
    }
}
