using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1EDUKOS
{
    internal class Deposit : Transaction
    {
        private User user;
        public Deposit(User user, double amount, DateTime date)
        {
            this.user = user;
            this.Amount = amount;
            this.Date = date;
        }

        public override void CompleteTransaction()
        {
            user.Deposit(Amount);



        }
    }
}

