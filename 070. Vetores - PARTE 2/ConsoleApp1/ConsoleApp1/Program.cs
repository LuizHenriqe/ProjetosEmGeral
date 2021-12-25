using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                vect[i] = new Produto { Nome = name, Preco = price };
            }

            double sum = 0;

            for (int i = 0; i < n; i++) {
                sum += vect[i].Preco;
            }
            sum = sum / n ;

            Console.WriteLine(sum);

        }
    }
}
