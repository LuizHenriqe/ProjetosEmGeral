using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(string[] args) {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Voce digitou: {n1}");
            Console.WriteLine($"Voce digitou: {ch}");
            Console.WriteLine($"Voce digitou: {n2.ToString("F2",CultureInfo.InvariantCulture)}");

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"primeira palavra: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"altura: {altura.ToString(CultureInfo.InvariantCulture)}");

            //



        }
    }
}
