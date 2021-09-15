using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y; //declarar variaveis de tipos de classe

            x = new Triangulo(); //instansiando a varivel (criação)
            y = new Triangulo(); //instansiando a varivel (criação)

            Console.WriteLine("Digite o tamanho da area X:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o tamanho da area X:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            Console.WriteLine($"Valor da area X: {areaX.ToString("F4",CultureInfo.InvariantCulture)}.");

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.WriteLine($"Valor da area Y: {areaY.ToString("F4",CultureInfo.InvariantCulture)}.");

            Console.WriteLine("A maior area é:");
            if (areaX > areaY) {
                Console.WriteLine("Area X.");
            }
            else {
                Console.WriteLine("Area Y.");
            }

        }
    }
}
