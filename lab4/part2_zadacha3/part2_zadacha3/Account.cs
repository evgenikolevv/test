using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_zadacha3
{
    class Account
    {
        public int Balance { get; set; }
        public int Credit { get; set; }
        public int Debit { get; set; }
        public int Sum { get; set; }

        public void putMoney(int sum)
        {
            if (sum <= 0)
            {
                Console.WriteLine("Cannot put less than 1");
                return;
            }
            Sum = sum;
            Credit += sum;
            Balance += Sum;
        }

        public void getMoney(int sum)
        {
            if (sum <= 0 || sum > Balance)
            {
                Console.WriteLine("Cannot withdraw.");
                return;
            }
            Sum = sum;
            Debit += sum;
            Balance -= Sum;
        }

        public void Mes()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Balance : " + Balance + " Credit: " + Credit + " Debit: " + Debit + " Sum: " + Sum;
        }
    }
}
