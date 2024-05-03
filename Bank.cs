using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1EDUKOS
{
    class Bank
    {
       
         private List<User> users = new List<User>();
         public Bank(List<User> users)
         {
             this.users = users;
         }
         public void ExecuteTransaction(Transaction transaction)
         {
             transaction.CompleteTransaction();
         }
        }
}
