using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            double saldo = 10.2990;

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            int idade = 22;
            double saldo1 = 29.387;
            string nome = "Luiz";

            // Placeholders
            Console.WriteLine("{0}, tem {1} anos, e possui o saldo de {2:F2} reais.", nome, idade, saldo1);
            
            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos, e tem saldo igual a {saldo1:F2} reais.");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade "anos e tem o saldo de "+ saldo.ToString("F2",CultureInfo.InvariantCulture));

        }
    }

}