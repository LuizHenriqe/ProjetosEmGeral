using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            
            Conta c = new Conta();
            c.RespostaWhile = 0;

            while (c.RespostaWhile != 1) {
                Console.WriteLine("Selecione uma das operaçoes de 1 a 4: ");

                Console.WriteLine("1.Adição\n2.Subtração\n3.Multiplicação\n4.Divisão");
                c.SelecionaOperacao = Console.ReadLine();

                c.EfetuaverificacaoOperacao();

                Console.Write("Digite o primeiro numero: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                double n2 = double.Parse(Console.ReadLine());
                c.EfetuaOperacao(n1, n2);

                Console.Write("Deseja continuar? S = Sim, N = Não ");
                c.Resposta = Console.ReadLine();
                c.Finalizar();
            }

        }
    }
}
