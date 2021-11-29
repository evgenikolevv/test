using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBall sportBall = new SportBall(10, "Football", SportCategory.Collective);
            sportBall.width = 28;
            sportBall.length = 40;
            Console.WriteLine("Sport Characteristics");
            Console.WriteLine("Name of sport: " + sportBall.NameOfSport);
            sportBall.SportCharacteristics();
            Console.WriteLine("# of Players: " + sportBall.NumberOfPlayers);
            Console.WriteLine("Court Dimensions: " + sportBall.width + "m x " + sportBall.length + "m");
            Console.ReadLine();
        }
    }
}
