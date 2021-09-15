using System;
using System.Globalization;
using System.Collections.Generic;

namespace programa {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a quantidade que haverá na matrz de linhas/colunas: ");
            string[] line = Console.ReadLine().Split(' ');

            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] matriz = new int[m, n];

            //inserindo os dados na matriz
            // inserindo dados da linha.
            for (int a = 0; a < m; a++) {
                // Pegando os valores
                string[] values = Console.ReadLine().Split(' ');
                for (int b = 0; b < n; b++) {
                    matriz[a, b] = int.Parse(values[b]); 
                }
            }

            int x = int.Parse(Console.ReadLine());
            for (int a = 0; a <m; a++) {

                for (int b = 0; b < n; b++) {
                    if (matriz[a,b] == x) {
                        Console.WriteLine("Position " + a + ", " + b + ":");
                        if (b > 0) {
                            Console.WriteLine("Left: " + matriz[a, b- 1] );
                        }
                        if (a > 0) {
                            Console.WriteLine("Up: " + matriz[a - 1, b]);
                        }
                        if (b > n - 1) {
                            Console.WriteLine("Right: " + matriz[a, b + 1]);
                        }
                        if (b > m - 1) {
                            Console.WriteLine("Down: " + matriz[a + 1, b]);
                        }

                    }
                }
            }
        }
    }
}
