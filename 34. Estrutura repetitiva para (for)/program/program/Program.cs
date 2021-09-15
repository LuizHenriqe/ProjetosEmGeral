using System;

namespace program {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= 5; i++) {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
                //ou soma = soma + valor;
            }
            Console.WriteLine($"Total: {soma}");
        }
    }
}
