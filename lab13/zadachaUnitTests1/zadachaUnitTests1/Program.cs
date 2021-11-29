using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachaUnitTests1
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation();
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            String result = equation.calculate(num1, num2, num3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
