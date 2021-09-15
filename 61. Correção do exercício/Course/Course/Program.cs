using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Deseja fazer deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's'|| resposta == 'S') {
                Console.Write("Entre o valor de deposito inicial: $ ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\n"+ conta);
        }
    }
}
