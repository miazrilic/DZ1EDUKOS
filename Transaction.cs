using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1EDUKOS
{
    public abstract class Transaction
    {
        
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public abstract void CompleteTransaction();


    }
}
