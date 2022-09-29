using System;

namespace Program {
    class Program {
        static void Main(string[] args) {

            // Utilizando REF
            int a = 10;
            Conta.Triple(ref a);
            Console.WriteLine(a);

            // Utilizando out
            int b = 5;
            int triple;
            Conta.Triple2(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
