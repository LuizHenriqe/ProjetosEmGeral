using System;
using System.Threading;
using System.Globalization;

namespace EXERCICIO04 {
    class Program {
        static void Main(string[] args) {
            /* //exercicio 01
            Console.WriteLine("Digite quantas numeros deseja ver.");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            //exercicio 02
            Console.WriteLine("Digite a quantidade que deseja ver:");
            int n = int.Parse(Console.ReadLine());
            int numero;
            int dentro = 0;
            int fora = 0;

            for (int x = 1; x <= n; x++) {

                Console.Write($"Digite o {x}° numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }

            Thread.Sleep(1500);
            Console.Clear();
            Thread.Sleep(1000);

            Console.WriteLine("Dados informativos: ");
            Console.WriteLine($"{dentro} in. \n{fora} out.");
            // Exercicio 03
            Console.WriteLine("Digite quantos valores vao ser passados:");
            int n = int.Parse(Console.ReadLine());
            double a, b, c, media;

            for (int i = 0; i <= n; i++) {

                Console.WriteLine("Digite os tres pesos e ache a média:");
                string[] pesos = Console.ReadLine().Split(" ");
                a = double.Parse(pesos[0],CultureInfo.InvariantCulture);
                b = double.Parse(pesos[1],CultureInfo.InvariantCulture);
                c = double.Parse(pesos[2],CultureInfo.InvariantCulture);

                media = (a + b + c) / 3;

                Console.WriteLine($"{media.ToString("F1",CultureInfo.InvariantCulture)}.");

            // Exercicio 04
            Console.WriteLine("Digite a quantidade de vez em que o numero sera repetido");
            int num = int.Parse(Console.ReadLine());
            double a, b, soma;

            for (int i = 1; i <= num; i++) {
                Console.WriteLine("Digite o 1° numero (numerador) depois o 2°(denominador)");
                string[] numeros = Console.ReadLine().Split(" ");
                a = double.Parse(numeros[0],CultureInfo.InvariantCulture);
                b = double.Parse(numeros[1],CultureInfo.InvariantCulture);

                if (b == 0.0) {
                    Console.WriteLine("Divisão Invalida!!");
                }
                else {
                    soma = a / b;
                    Console.WriteLine($"O numero {a} dividido {b} é igual á: {soma.ToString("F2",CultureInfo.InvariantCulture)}");
                }
            }
            // Exercicio 05

            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }


            Console.WriteLine(fat);


            // Exercicio 06

            Console.Write("Calculando seus divisores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }

            */
            // Exercicio 07
            Console.WriteLine("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }


        }
    }
}
