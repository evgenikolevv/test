using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Box dimensions = new Box((float)76.2, (float)50.8);
            dimensions.LengthInches = dimensions.lengthInches();
            dimensions.WidthInches = dimensions.widthInches();

            Console.WriteLine("Inch:  length: {0:F1} ", dimensions.LengthInches);
            Console.WriteLine("Inch:  width: {0:F1}", dimensions.WidthInches);

            dimensions.LengthInches = dimensions.LengthCm();
            dimensions.WidthInches = dimensions.WidthCm();

            Console.WriteLine("Cm:  length: {0:F1} ", dimensions.LengthInches);
            Console.WriteLine("Cm:  width: {0:F1}", dimensions.WidthInches);

            Console.ReadLine();
        }
    }
}
