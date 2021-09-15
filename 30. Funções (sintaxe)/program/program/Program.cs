using System;

namespace program {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite tres numeros:");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            /*
            if (n1 > n2 && n1 > n3) {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3) {
                Console.WriteLine("Maior = " + n2);
            }
            else {
                Console.WriteLine("Maior = " + n3);
            }

            podemos usar desse jeito porem temos um modo mais simples.
            */

            double resultado = Maior(n1, n2, n3); // chama a função "Maior" (n1...) <- sao os parametros
             Console.WriteLine("Maior é = " + resultado);
        }

        static int Maior(int a, int b, int c) {
            int m;

            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m; // Retorna o valor para quem esta chamando a função.
        }
    }
}
