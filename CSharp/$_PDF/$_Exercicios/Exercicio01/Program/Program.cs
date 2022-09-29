using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 21;
            int codigo = 789755;
            char genero = 'M'; 

            double medida = 53.23456700;
            double preco_produto1 = 2100.99;
            double preco_produto2 = 501.99;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco_produto1}.");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco_produto2}. \n");
            Console.WriteLine($"{idade} anos, Codigo {codigo}, genero:{genero}.");
            Console.WriteLine($"medida com oito casas decimais: {medida}.");
            Console.WriteLine($"Arredondando (tres casa decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");

        }

    }
}
