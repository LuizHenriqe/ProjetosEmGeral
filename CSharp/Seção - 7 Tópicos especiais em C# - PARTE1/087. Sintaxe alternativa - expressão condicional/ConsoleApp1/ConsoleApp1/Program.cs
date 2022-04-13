using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*double desconto;

            if(preco < 20.0) {
                desconto = preco * 0.1;
            }
            else{
                desconto = preco * 0.05;
            }

            ou

            */

            // Pode ser utilizado no lugar do if
            double desconto = (preco < 20.0) ? preco * 0.10 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
