using System;
using System.Threading;
namespace programa {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Bem vindo, cadastre sua conta!!");

            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Dados d = new Dados(conta, nome);

            Console.Write("Havera deposito inicial: (s/n)? ");
            string resposta = Console.ReadLine();

            d.Carregar();
            
            double deposito;
            if (resposta.ToUpper() == "S") {
                Console.Write("Entre o valor de deposito inicial: ");
                deposito = double.Parse(Console.ReadLine());
                d.AdicionaDeposito(deposito);
                d.Carregar();
            }

            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(d);

            Console.ReadLine();
            Console.Clear();

            Console.Write("Entre um valor para deposito: ");
            deposito = double.Parse(Console.ReadLine());
            d.AdicionaDeposito(deposito);

            d.Carregar();

            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(d);

            Console.ReadLine();
            Console.Clear();

            Console.Write("entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());

            d.Carregar();

            Console.WriteLine("Dados atualizados:");
            d.SaqueConta(saque);
            Console.WriteLine(d);

        }
    }
}
