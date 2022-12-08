using System;

namespace programa {
    class Program {
        static void Main(string[] args) {
            
            int a = 10;

            bool condicao_1 = a < 10;
            bool condicao_2 = a < 20;
            bool condicao_3 = a > 10;
            bool condicao_4 = a > 5;

            Console.WriteLine(condicao_1);
            Console.WriteLine(condicao_2);
            Console.WriteLine(condicao_3);
            Console.WriteLine(condicao_4);
            Console.WriteLine("----------------------");

            bool condicao_5 = a <= 10;
            bool condicao_6 = a >= 10;
            bool condicao_7 = a == 10;
            bool condicao_8 = a != 10;

            Console.WriteLine(condicao_5);
            Console.WriteLine(condicao_6);
            Console.WriteLine(condicao_7);
            Console.WriteLine(condicao_8);




        }
    }
}
