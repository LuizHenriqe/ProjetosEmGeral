using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos numeros pretende utilizar p/ a média?");
            int n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];

            for (int i= 0; i < n; i++) {
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            double soma = 0;

            for (int i = 0;i < n; i++) {
                soma += numeros[i];
            }

            double divi = soma / n;
            Console.WriteLine(divi);
        }
    }
}
