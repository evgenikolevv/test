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
            Demo[] demo = new Demo[5];

            Figure square = new Figure("квадрат", 4, 4);
            Figure squareSecond = new Figure("квадрат", 6, 6);
            Figure rectangle = new Figure("правоъгълник", 4, 5);
            Box cube = new Box("куб",4, 4, 4);
            Box paralelepiped = new Box("паралелепипед",4, 5, 6);

            demo[0] = square;
            demo[1] = rectangle;
            demo[2] = cube;
            demo[3] = paralelepiped;
            demo[4] = squareSecond;

           for(int i = 0; i < demo.Length; i++)
            {
                demo[i].Show();
            }
            Console.ReadLine();
        }
    }
}
