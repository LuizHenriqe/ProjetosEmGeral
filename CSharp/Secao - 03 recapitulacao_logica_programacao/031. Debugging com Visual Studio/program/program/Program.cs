using System;

namespace Course{
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite 3 numeros: ");

            //F5: Executa o codigo inteiro ou ate o BREAKPOINT.
            //F10: Executa o codigo linha por linha.
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            //F9: Cria um Breakpoint.
            int n3 = int.Parse(Console.ReadLine());

            //F11: Executa linha por linha dentro de uma função fora da principal.
            double resultado = Maior(n1, n2, n3); 

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
            return m;
        }
    }
}
