using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 200, 10);
            Console.WriteLine("Client: " + client.Name);
            Console.WriteLine("Initial sum: " + client.Balance);
            Console.WriteLine("Percentage: " + client.Interest);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Put money");
            float money = float.Parse(Console.ReadLine());
            client.addMoney(money);
            Console.WriteLine("Sum: " + client.Balance);

            Console.WriteLine("Withdraw:");
            float withdraw = float.Parse(Console.ReadLine());
            client.getMoney(withdraw);
            Console.WriteLine("Sum: " + client.Balance);
            Console.ReadLine();
        }
    }
}
