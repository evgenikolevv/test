using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password");
            string password = Console.ReadLine();
            
            
            Console.WriteLine(validation.validateUsername(username));
            Console.WriteLine(validation.validatePassword(password));
            Console.ReadLine();
        }
    }
}
