using System;
using System.Globalization;
using System.Threading;

namespace Program {
    class Conta {
        // variaveis
        public string SelecionaOperacao;
        public string Resposta;
        public int RespostaWhile = 0;

        //funçoes
        public void EfetuaverificacaoOperacao() {
            int i = 0;

            while (i != 1) {
                if (SelecionaOperacao == "1") {
                    Console.Clear();
                    Console.WriteLine("Conta de --> Adição <--");
                    Console.WriteLine();
                    i = 1;
                }
                else if (SelecionaOperacao == "2") {
                    Console.Clear();
                    Console.WriteLine("Conta de --> Subtração <--");
                    Console.WriteLine();
                    i = 1;
                }
                else if (SelecionaOperacao == "3") {
                    Console.Clear();
                    Console.WriteLine("Conta de --> Multiplicação <--");
                    Console.WriteLine();
                    i = 1;
                }
                else if (SelecionaOperacao == "4") {
                    Console.Clear();
                    Console.WriteLine("Conta de --> Divisão <--");
                    Console.WriteLine();
                    i = 1;
                }
                else {
                    Console.Clear();
                    Console.WriteLine("operação invalida!!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("Selecione uma das operaçoes de 1 a 4: ");
                    Console.WriteLine("1.Adição\n2.Subtração\n3.Multiplicação\n4.Divisão");
                    SelecionaOperacao = Console.ReadLine();
                   
                }
            }
        }

        public void EfetuaOperacao(double a, double b) {
            double soma = 0;

            if (SelecionaOperacao == "1") {
                soma = a + b;
            }
            else if (SelecionaOperacao == "2") {
                soma = a - b;
            }
            else if (SelecionaOperacao == "3") {
                soma = a * b;
            }
            else if (SelecionaOperacao == "4") {
                soma = a / b;
            }
            else {
                int c = 0;
                soma = c + c;
            }
            Console.WriteLine(soma );               
            Console.WriteLine("Aperte enter para apagar tudo.");
            Console.ReadLine();
            Console.Clear();

        }

        public void Finalizar() {
            int o = 0;

            while (o != 1) {
                if (Resposta == "s") {
                    Console.WriteLine("Voltando ao inicio!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    o = 1;
                }
                else if (Resposta == "n") {
                    Console.WriteLine("Finalizando o Programa!!");
                    o = 1;
                    RespostaWhile = 1;
                }
                else {
                    Console.WriteLine("Opção invalida!!");

                    Resposta = Console.ReadLine();

                }
            }
        }
    }
}
