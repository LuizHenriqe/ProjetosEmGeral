using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            // COnceito de  Boxing e unboxing, 
            int x = 20;
            int y = 25;

            object obj = x + y;

            int ap = (int) obj;

            Console.WriteLine(ap);
        }
    }
}
