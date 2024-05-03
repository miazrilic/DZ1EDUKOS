using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1EDUKOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(233234, "Mia", "Zrilic", 1111);
            User user2 = new User(342414, "Nina", "Sucic", 2222);

            user1.Deposit(23123);
            user2.Withdraw(1000);

            Console.WriteLine($"User1 balance: {user1.CheckBalance()}");
            Console.WriteLine($"User2 balance: {user2.CheckBalance()}");

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);

            Bank bank = new Bank(users);

            Transaction transaction1 = new Deposit(user2, 33234, new DateTime(2022, 12, 25));
            bank.ExecuteTransaction(transaction1);

            Transaction transaction2 = new Withdrawal(user1, 56466, new DateTime(2024, 11, 5));
            bank.ExecuteTransaction(transaction2);

            Console.WriteLine($"User1 balance after bank transaction: {user1.CheckBalance()}");
            Console.WriteLine($"User2 balance after bank transaction: {user2.CheckBalance()}");

        }
    }
}


