using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // Define falso ou verdadeiro.
            bool completo = false;

            // O tipo char serve para guardar um caracter unicode
            char genero = 'M';

            // Colocando o começo \u = codigo unicode
            char letra = '\u0041';

            // obs.: para indicar explicitamente que a varialvel é um float tem que colocar "f" na frente
            float n5 = 4.5f;    // variavel flutuante

            // ou 

            double n6 = 4.7;

            //
            string nome = "Luiz Henrique";

            object obj1 = "LUUUUiz";
            object obj2 = 4.5f;

            

            // --> Imprime na tela.
            Console.WriteLine(nome);
            Console.WriteLine(n6);
            Console.WriteLine(n5);
            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            // final da aula .int... mostra maximo e minimo permitido.
            int n1n = int.MaxValue;
            int n2n = int.MinValue;
            sbyte n3n = sbyte.MaxValue;
            sbyte n4n = sbyte.MinValue;
            decimal n5n = decimal.MaxValue;

            Console.WriteLine(n5n);
            Console.WriteLine(n4n);
            Console.WriteLine(n3n);
            Console.WriteLine(n1n);
            Console.WriteLine(n2n);
        }
    }

}