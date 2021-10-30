using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // Oque é entrepoint?

            Console.WriteLine("Digite tres numeros:");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            // chama a função "Maior".
            double resultado = Maior(n1, n2, n3); 
            // Faz o print na tela.
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

            // Retorna o valor na função.
            return m; 
            
        }
    }
}

/*
 * estrutura usada no MAIN
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
