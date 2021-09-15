using System;

namespace Program {
    class Program {
        static void Main(string[] args) {

            int receveValor = int.Parse(Console.ReadLine());
            int receveValor2 = int.Parse(Console.ReadLine());

            int valor1 = Calculator.Sum( receveValor, receveValor2);
            // int valor2 = Calculator.Sum(10,40,12);

            Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
         }
    }
}
