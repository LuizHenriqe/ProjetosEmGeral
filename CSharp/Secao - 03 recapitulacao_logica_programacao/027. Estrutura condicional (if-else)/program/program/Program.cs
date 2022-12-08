using System;

namespace program {
    class Program {
        static void Main(string[] args) {

            // condição simples
            int a = 10;

            if (a < 12) {
                Console.WriteLine("Boa tarde");
            }

            // condição composta

            Console.WriteLine("Digite um numero:");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Numero Par!!");
            }
            else {
                Console.WriteLine("Numero Impar!!");

            }

            // encadeamento
            Console.WriteLine("Qual a hora atual? ");

            int hora = int.Parse(Console.ReadLine());
            
            if (hora < 6) {
                Console.WriteLine("Boa madrugada");
            }
            else if (hora < 12) {
                Console.WriteLine("Bom dia!!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!!");
            }
            else {
                Console.WriteLine("Boa noite!!");
            }
        }
    }
}
