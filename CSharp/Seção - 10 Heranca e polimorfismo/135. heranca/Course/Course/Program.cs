using System;
using Course.Entites;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BusinessAccount account = new BusinessAccount(100, "Henrique", 50000, 500);

            Console.WriteLine(account.Balance);

        }
    }
}
