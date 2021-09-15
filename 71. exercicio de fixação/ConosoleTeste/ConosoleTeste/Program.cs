using System;

namespace ConosoleTeste {
    class Program {
        static void Main(string[] args) {

            Estudante[] listaEstudante = new Estudante[10];


            Console.Write("Quantos quartos serao alugados? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeQuartos; i++ ) {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                listaEstudante[quarto] = new Estudante(nome, email);
            }

            for (int i = 0; i < 10; i++) {
                if (listaEstudante[i] != null) {
                    Console.WriteLine($"{i}: {listaEstudante[i]}");
                }
            }
        }
    }
}

