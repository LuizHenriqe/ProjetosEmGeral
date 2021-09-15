using System;

namespace program {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite 3 numeros: ");

            // Para executar o codigo linha por linha aperte F10
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            // Breakpoint: em cima da linha do codigo aperte F9
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); // cpara executar uma linha que contenha uma função aperte F11
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
