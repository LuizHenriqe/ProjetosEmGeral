using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("terminado");

            string[] vet = Console.ReadLine().Split(" ");
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine($"Voce digitou: {frase}");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
