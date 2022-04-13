using System;
using System.Globalization;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
            /*
            //Exercicio 1 -->>
            int a, b, soma;
            
            Console.WriteLine("Digite o primeiro numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segudo numero:");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine($"a soma entre {a} e {b} é equivalente á: {soma}");

            //exercicio2 -->>

            double pi = 3.14159, A, R;

            Console.WriteLine("Digite o numero: ");

            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine($"O valor do raio de um circulo digitado é: {R.ToString("F2",CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"O valor da area do circulo é igual á: {A.ToString("F4",CultureInfo.InvariantCulture)}.");
            
            // Exercicio 3 -->>

            int a, b, c, d, diferenca;

            Console.WriteLine("Digite o primeiro numero:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto numero:");
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            Console.WriteLine($"A doferença entre ab e cd é igual á: {diferenca}");
            
            //Exercicio 4 -->>
            int id;
            double ganhoPorHora, horas, salario;

            Console.WriteLine("Digite o ID:");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas foram trabalhadas:");
            horas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("ganhos por hora:");
            ganhoPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = horas * ganhoPorHora;

            Console.WriteLine("Seu ID é: {0}",id);
            Console.WriteLine($"Seu salario é de {salario.ToString("F2",CultureInfo.InvariantCulture)}.");
            
            // Exercicio 5 -->>

            int cod1, qte1, cod2, qte2;
            double valor1,valor2,total;


            Console.WriteLine("Digite o codigo do produto, quantidade e tamanho separe por espaços:");
            string[] vet = Console.ReadLine().Split(" ");
            cod1 = int.Parse(vet[0]);
            qte1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(" "); // usei o mesmo vetor
            cod2 = int.Parse(vet[0]);
            qte2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2],CultureInfo.InvariantCulture);


            total = qte1 * valor1 + qte2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: {total.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
