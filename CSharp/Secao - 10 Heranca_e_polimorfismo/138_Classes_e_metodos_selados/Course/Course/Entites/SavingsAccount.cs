using System;
using System.Collections.Generic;
using System.Text;



namespace Course.Entites {
    internal class SavingsAccount: Account {
        public double InterestRate { get; set; }

        public SavingsAccount() {
            
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) 
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        // palavra sealed, serve para evitar que um  metodo  nao seja sobreposto
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2;
        }
    }
}
