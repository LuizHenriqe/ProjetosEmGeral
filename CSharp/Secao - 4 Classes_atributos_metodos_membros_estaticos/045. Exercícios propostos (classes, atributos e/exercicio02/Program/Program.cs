using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.WriteLine("Digite as informações a seguir: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Informando dados:" + f);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            f.AumentarSalario(porcent);

            Console.WriteLine($"Dados atualizados: {f}");

           
        }
    }
}
