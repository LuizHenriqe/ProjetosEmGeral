using System;
using System.Globalization;

namespace program {
    class Program {
        static void Main(string[] args) {

            // estrutura de repetição "Enquanto".
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);

                Console.WriteLine("A raiz de {0} é igual á {1}",x,raiz.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Aperte enter!!!");
                Console.ReadLine();
                
                Console.Clear();
                Console.Write("Digite outro numero:");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo!!");
        }
    }
}
