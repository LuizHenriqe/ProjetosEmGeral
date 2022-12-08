using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entites;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Account acc1 = new Account(1001,"Luiz", 500.0);
            //Account acc2 = new SavingsAccount(1002,"Teste",500.0, 0.01);

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach(Account account in list)
            {
                sum += account.Balance;

            }
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account account in list)
            {
                account.WithDraw(10.0);
            }

            foreach(Account ac in list)
            {
                Console.WriteLine("Update: " + ac.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
