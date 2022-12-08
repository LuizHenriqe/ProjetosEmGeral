using System;

namespace operadores {
    class Program {
        static void Main(string[] args) {
            // Exemplo 1

            int a = 10;
            // primeiro ele atribui o valor da variavel "A" para a variavel "B"
            int b = a++; 
            // a variavel A imprime como 11e a varivavel b imprime como 10
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Exemplo 2
            int c = 10;
            int d = ++c;

            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
