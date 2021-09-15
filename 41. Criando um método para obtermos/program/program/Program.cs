using System;
using System.Globalization;

namespace program {
    class Program {
        static void Main(string[] args) {
            //melhorando a classe da aula 39.
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os valores do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os valores do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area X = " + areaX.ToString("F4",CultureInfo.InvariantCulture) );
            Console.WriteLine("Area Y = " + areaY.ToString("F4",CultureInfo.InvariantCulture) );

            if (areaX > areaY) {
                Console.WriteLine("A maior area é X!!");
            }
            else {
            Console.WriteLine("A maior area é Y!!");
            }

        }
    }
}
