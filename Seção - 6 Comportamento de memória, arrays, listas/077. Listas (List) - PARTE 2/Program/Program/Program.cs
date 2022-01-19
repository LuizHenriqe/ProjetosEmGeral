using System;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Main(string[] args) {

            // Criando lista
            List<string> nome = new List<string>();

            // adicionando valores a lista com add e insert
            nome.Add("Luiz");
            nome.Add("Test");
            nome.Add("Luca");
            nome.Add("variavel");
            nome.Add("Lion");
            nome.Insert(1, "Intruso"); // voce pode definir a posição do valor,
                                       // neste exemplo o valor vai ser encaixado na posição 1
            Console.WriteLine("-----------------------------------------------");

            foreach (string nomeIsolado in nome) {
                Console.WriteLine(nomeIsolado);
            }
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("List Count: " + nome.Count); // contando a quantidade de valores na lista

            Console.WriteLine("-----------------------------------------------");
            // encontrando um valor...

            // função teste
            string s2 = nome.Find(Test); 
            Console.WriteLine(s2);

            // função lambida
            string s1 = nome.Find(x => x[0] == 'L');
            Console.WriteLine("First name starting with L: "+ s1);

            // achando pelo ultimo nome que começa com a letra L
            string s3 = nome.FindLast(x => x[0] == 'L');
            Console.WriteLine("Last name starting with L: " + s3);

            Console.WriteLine("-----------------------------------------------");
            int pos1 = nome.FindIndex(x => x[0] == 'L');
            Console.WriteLine("First position with 'L':  " + pos1);

            int pos2 = nome.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine("Last position with 'L': " + pos2);
            
            Console.WriteLine("-----------------------------------------------");
            List<string> nome2 = nome.FindAll(x => x.Length == 4);
            foreach (string obj in nome2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------");
            nome.Remove("Test"); // remove um valor em especifico
            foreach (string obj in nome) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------");
            nome.RemoveAll(x => x[0] == 'L'); // remove tudo que conter a letra L como inicial
            foreach (string obj in nome) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------");
            nome.RemoveAt(2); // remove o valor de posição 2
            foreach (string obj in nome) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------");
            nome.RemoveRange(2, 2);
            
            foreach (string obj in nome) {
                Console.WriteLine(obj);
            }
        }

        // podemos construir uma classe que  faça isso
        static bool Test(string s) {

            return s[0] == 'I';
        }
    }
}
