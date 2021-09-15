using System;
using System.Globalization;


namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circuferencia(raio);
            double Volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
