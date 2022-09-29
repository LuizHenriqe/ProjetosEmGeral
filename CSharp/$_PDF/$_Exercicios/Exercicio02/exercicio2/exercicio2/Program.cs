using System;
using System.Globalization;
using System.Threading;

namespace exercicio2 {
    class Program {
        static void Main(string[] args) {
            /*
            // exercicio 01
            int a;
            a = int.Parse(Console.ReadLine());

            if (a < 0) {
                Console.WriteLine("Numero negativo");
            }
            else {
                Console.WriteLine("Numero positivo");
            }

            // exercicio 02
            int n; 
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                Console.WriteLine("Numero Par.");
            }
            else {
                Console.WriteLine("Numero Impar.");
            }

            // exercicio 03
            Console.WriteLine("Digite 2 numeros separados por espaço e descubra se é multiplo:");

            int a, b;

            string[] vet = Console.ReadLine().Split(" ");
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não é multiplo");
            }


            // exercicio 04
            int horaInicial, horaFinal, duracao;
            Console.WriteLine("Digite a hora inicio e hora final:");
            string[] vet = Console.ReadLine().Split(" ");

            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($"O jogo durou {duracao} Hora(S)");

            // exercicio 05

            string[] vet = Console.ReadLine().Split(" ");
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double total;

            if (codigo == 1) {
                total = quantidade * 4.00;
            }
            else if (codigo == 2) {
                total = quantidade * 4.50;
            }
            else if (codigo == 3) {
                total = quantidade * 5.00;
            }
            else if (codigo == 4) {
                total = quantidade * 2.00;
            }

            else if (codigo == 5) {
                total = quantidade * 1.50;
            }
            else {

                total = quantidade * 0; 
                Console.WriteLine("Codigo invalido!");
            }

            Console.WriteLine($"Total a pagar: R${total.ToString("F2",CultureInfo.InvariantCulture)}.");

            // exercicio 06
            double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de alcance");
            }
            else if (numero <= 25.0) {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (numero <= 50.0) {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (numero <= 75.0) {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else {
                Console.WriteLine("Intervalo [75, 100]");
            }
            // exercicio 07

            double x, y;

            Console.WriteLine("Digite o valor de X e Y, logo saberas qual é o quadrante:");

            string[] vet = Console.ReadLine().Split(" ");
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem.");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y < 0.0) {
                Console.WriteLine("Q4");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo x");
            }
            else {
                Console.WriteLine("outra coisa:");
            }
            */
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
