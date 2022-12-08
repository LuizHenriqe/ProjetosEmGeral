using System;
using System.Globalization;

namespace exercico02 {
    class Program {
        static void Main(string[] args) {
            Funcionarios p1, p2;

            p1 = new Funcionarios();
            p2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine($"A media salarial é: {media.ToString("F4", CultureInfo.InvariantCulture)}");


        }
    }
}
