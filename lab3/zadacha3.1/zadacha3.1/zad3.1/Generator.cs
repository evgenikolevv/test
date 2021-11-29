using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3._1
{

    class Generator
    {

        public static void Generate() 
        {
            int tries = 0;

            while(true) 
            {
                Console.WriteLine("Enter a number between 1 and 100 (0 quit):");
                int number = Int32.Parse(Console.ReadLine());
                Random rand = new Random();
                int randomNumber = rand.Next(1, 100);
             
                tries++;
                if (number == randomNumber)
                {
                    Console.WriteLine("You guessed it! The number was " + number + "!");
                    Console.WriteLine("It took you " + tries + " tries");
                    Console.ReadLine();
                    break;
                }
                else if (number == 0)
                {
                    break;
                }
             

            }
        }
    }
}
