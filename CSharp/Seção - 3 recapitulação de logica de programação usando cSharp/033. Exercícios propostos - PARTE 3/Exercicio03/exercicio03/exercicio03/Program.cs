using System;
using System.Globalization;
using System.Threading;

namespace exercicio03 {
    class Program {
        static void Main(string[] args) {
            /* //execericio 1
            string senha;

            Console.WriteLine("Digite a senha: ");
            senha = Console.ReadLine();

            while (senha != "0000") {
                Console.Clear();
                Console.WriteLine("Senha Invalida!!");                
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Digite novamente a senha:");                
                senha = (Console.ReadLine());
                Thread.Sleep(2000);
            }
            Console.Clear();
            Console.WriteLine("Senha Correta!!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Acesso permitido");
            // Exercicio 02
            double x, y;

            Console.WriteLine("Digite o valor de X e Y, descubra o quadrante pertencente: ");

            string[] xy = Console.ReadLine().Split();
            x = double.Parse(xy[0]);
            y = double.Parse(xy[1]);

            while (x != 0 && y != 0) {

                if (x > 0.0 && y > 0.0) {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0.0 && y > 0.0) {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0.0 && y < 0.0) {
                    Console.WriteLine("Terceiro");
                }
                else {
                    Console.WriteLine("Quarto");
                }

                Thread.Sleep(2000); 

                xy = Console.ReadLine().Split();
                x = double.Parse(xy[0]);
                y = double.Parse(xy[1]);

            }
            Console.WriteLine("Fechando programa");
            */
            int alcool = 0, gasolina = 0, diesel = 0;
            int x= 0, adm = 0;
            string tipo;


            while (adm != 1) {

                Thread.Sleep(1500);

                Console.WriteLine("Digite o combustivel abastecido:\n");
                Thread.Sleep(1500);
                Console.WriteLine("1.Alcool\n2.Gasolina\n3.Diesel\n4.para finalizar.");
                tipo = Console.ReadLine();

                if (tipo == "1") {
                    alcool++;
                    Console.WriteLine("Muito Obrigado, volte sempre!!");
                }
                else if (tipo == "2") {
                    gasolina++;
                    Console.WriteLine("Muito Obrigado, volte sempre!!");
                }
                else if (tipo == "3") {
                    diesel++;
                    Console.WriteLine("Muito Obrigado, volte sempre!!");
                }
                else if (tipo == "4") {
                    //adm = fazer(x);
                    adm = funcao(x);
                }
                else {
                    Console.WriteLine("Invalido!!");
                }
                
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.Clear();

            Console.WriteLine(" --> Relatorio <--");
            Console.WriteLine($"Alcool: {alcool}.");
            Console.WriteLine($"Gasolina: {gasolina}.");
            Console.WriteLine($"Diesel: {diesel}.");
        }




        static int funcao(int a) {
        
        string m;
        int b;

        Console.WriteLine("Deseja finalizar?\nS = SIM ou N para NÃO.");
        m = Console.ReadLine();

        if (m == "s") {
            b = 1;
        }
        else {
            b = 0;
        }

        return b;
        
        }
    }
}
