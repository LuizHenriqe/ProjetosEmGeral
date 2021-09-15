using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(90000000L);
            TimeSpan t3 = new TimeSpan(2,11,21);
            TimeSpan t4 = new TimeSpan(1,2,11,21);
            TimeSpan t5 = new TimeSpan(1,2,11,21,321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("________________________");

            TimeSpan t6 = TimeSpan.FromDays(2.21);
            TimeSpan t7 = TimeSpan.FromHours(2.21);
            TimeSpan t8 = TimeSpan.FromMinutes(2.21);
            TimeSpan t9 = TimeSpan.FromSeconds(2.21);
            TimeSpan t10 = TimeSpan.FromMilliseconds(2.21);
            TimeSpan t11 = TimeSpan.FromTicks(9000000L);

            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);



        }
    }
}
