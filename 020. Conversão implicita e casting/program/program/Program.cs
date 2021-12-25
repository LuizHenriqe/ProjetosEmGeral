using System;

namespace program {
    class Program {
        static void Main(string[] args) {
            // Conversao implicita.
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            // cast
            double a = 5.1;

            float b = (float)a;

            Console.WriteLine(b);

            // 
            int c = (int)a;

            Console.WriteLine(c);

            int d = 5;
            int e = 2;

            double resultado = (double) d / e;// add um cast para converter de fato a variavel.

            Console.WriteLine(resultado);

        }
    }
}
