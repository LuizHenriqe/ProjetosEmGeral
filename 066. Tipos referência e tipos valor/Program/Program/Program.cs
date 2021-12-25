using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            //struct
            Teste t;
            t.X = 100;
            t.Y = 500;
            Console.WriteLine(t);

            t = new Teste();
            Console.WriteLine(t);
        }
    }
}
