 using System;
using System.Globalization;

namespace program {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dolar atual? ");
            ConversorDeMoedas.Dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoedas.CompraDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ConversorDeMoedas.ConverteDolarEmReal();
            Console.WriteLine(ConversorDeMoedas.Real);


        }
    }
}
