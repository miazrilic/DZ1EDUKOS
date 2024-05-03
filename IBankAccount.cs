using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1EDUKOS
{
    internal interface IBankAccount
    {
        double CheckBalance();
        void Withdraw(double amount);
        void Deposit(double amount);
    }
}
