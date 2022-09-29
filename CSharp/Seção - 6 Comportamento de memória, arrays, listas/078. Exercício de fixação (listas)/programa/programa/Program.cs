using System;
using System.Globalization;
using System.Collections.Generic;

namespace programa {
    class Program {
        static void Main(string[] args) {

            List<Funcionarios> lista = new List<Funcionarios>();

            Console.Write("Digite quanto funcionarios serao cadastrados: ");
            int resposta = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= resposta;i++) {
                Console.WriteLine($"Funcionario #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionarios(id,name,salario));
            }

            Console.WriteLine("digite o id que deseja aumentar o valor");
            int searchId = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser aumentado");
            double porcentagem = double.Parse(Console.ReadLine());
            
            Funcionarios s1 = lista.Find(x => x.Id == searchId);
            if (s1 != null) {
                s1.EfetuaPorcentagem(porcentagem);
            }


            foreach (Funcionarios obj in lista) {
                Console.WriteLine(obj);
            }
        }
    }
}
