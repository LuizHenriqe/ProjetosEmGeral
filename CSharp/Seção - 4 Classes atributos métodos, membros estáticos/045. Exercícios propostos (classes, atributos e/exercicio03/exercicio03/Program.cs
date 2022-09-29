using System;
using System.Globalization;

namespace exercicio03 {
    class Program {
        static void Main(string[] args) {
            Aluno a = new Aluno();

            Console.WriteLine("Digite os dados a seguir: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("1° nota: ");
            double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("2° nota: ");
            double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("3° nota: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a.MediaNotas(nota1, nota2, nota3);

            Console.WriteLine(a);

        }
    }
}
