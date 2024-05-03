using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1EDUKOS
{
     class User: Person, IBankAccount
    {
        public int AccountNumber {  get; set; }
        private double CurrentAmount  { get; set; }

        public User(double CurrentAmount, string FirstName, string LastName, int AccountNumber)
        {
            this.CurrentAmount= CurrentAmount;
            
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AccountNumber = AccountNumber;
        }

        public double CheckBalance()
        { return CurrentAmount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= CurrentAmount && CurrentAmount > 0)
            {
                CurrentAmount = CurrentAmount - amount;
            }
        }
        public void Deposit(double amount)
        {
            CurrentAmount = CurrentAmount + amount;
        }
    }
}
