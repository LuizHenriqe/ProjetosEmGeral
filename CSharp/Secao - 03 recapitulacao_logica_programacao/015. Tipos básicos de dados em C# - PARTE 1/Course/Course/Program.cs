using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            
            // tipo pré definido
            sbyte x = 100;  

            // é um tipo do .net (só funciona se a biblioteca using Sytem estiver declara)
            SByte y = 100;
            
            // nao aceita numero negativo
            byte n1 = 126;
            
            // fazendo dar overflow como exemplo seguindo o operador
            byte n1n = 255 ;
            n1n++; //operador pra icrementar a variavel 

            // explorando ao maximo o limite permito no codigo
            int n2 = 1000;
            int n3 = 2147483647;
            //long suporta mais numeros recomendado coloca a letra L no final para especificar a varialvel como long.
            long n4 = 2147483648L;

            Console.WriteLine(n4);
            Console.WriteLine(n3);
            Console.WriteLine(n2);
            Console.WriteLine(n1n);
            Console.WriteLine(n1);
            Console.WriteLine(x);

        }
    }
}
