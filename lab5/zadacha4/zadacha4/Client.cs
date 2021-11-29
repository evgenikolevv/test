using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Client : IAccount
    {   
        public string Name { get;set;}

        private float balance;
        private float interest;
        public float Balance =>  balance;

        public float Interest => interest;

        public Client(string name, float balance, float interest)
        {
            Name = name;
            this.balance = balance;
            this.interest = interest;
        }
        public void addMoney(float money)
        {
            balance += money;
        }

        public void getMoney(float money)
        {
            balance -= money;
        }
    }
}
