using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            while (true)
            {
                Console.WriteLine("1.Show Balance");
                Console.WriteLine("2.Put Money");
                Console.WriteLine("3.Get Money");
                Console.WriteLine("4.Exit");
                String choice = Console.ReadLine();

                
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Balance : " + account.Balance);
                        break;
                    case "2":
                        Console.WriteLine("Amount: ");
                        int amount = Int32.Parse(Console.ReadLine());
                        account.putMoney(amount);
                        break;
                    case "3":
                        Console.WriteLine("Amount: ");
                        int withdraw = Int32.Parse(Console.ReadLine());
                        account.getMoney(withdraw);
                        break;
                    case "4":
                        return;
                }
            }
        }
    }
}
