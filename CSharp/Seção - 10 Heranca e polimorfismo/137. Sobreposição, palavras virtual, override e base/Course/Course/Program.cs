using System;
using Course.Entites;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Account acc = new Account(1001,"LUiz", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002,"henrique", 0.0,500.0);
            


            // UpCasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "bob",0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DownCasting

            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc4.Loan(100.0);

            //Erro...
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if(acc3 is BusinessAccount) {
                // outra forma de fazer um casting 
                //BusinessAccount acc5 = (BusinessAccount)acc3;  -----> ou 
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!!");
            }
            if (acc3 is SavingsAccount) {

                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!");
            }
        }
    }
}
