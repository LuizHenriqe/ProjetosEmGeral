using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            // Nullable

            // Forma  errada de indicar uma variavel nula
            // double x = null;

            Nullable<double> uuu1 = null; // forma correta.
            double? uuu = null; // forma simplificada 

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            // teste 

            double? l = null;
            double? m = 10.0;

            //explicação: eu vou jogar o valor de Lem n porem se o L valer nulo ele coloca o seu valor a direita
            double n = l ?? 5.0; 
            double o = m ?? 0.0;

            Console.WriteLine("---------");
            Console.WriteLine(n);
            Console.WriteLine(o);
        }
    }
}
