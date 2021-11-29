using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    interface IAccount
    {
        float Balance { get; }
        float Interest { get; }

        void addMoney(float money);

        void getMoney(float money);


    }
}
