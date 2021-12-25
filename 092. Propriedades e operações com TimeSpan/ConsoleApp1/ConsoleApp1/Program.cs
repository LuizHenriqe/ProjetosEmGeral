using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Day: "+ t.Days);
            Console.WriteLine("Hours: "+ t.Hours);
            Console.WriteLine("Minutes: "+ t.Minutes);
            Console.WriteLine("Miliseconds: "+ t.Milliseconds);
            Console.WriteLine("Seconds: "+ t.Seconds);
            Console.WriteLine("Ticks: "+ t.Ticks);

            Console.WriteLine("TotalDay: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalMiliseconds: " + t.TotalMilliseconds);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);

            // teste 

            Console.WriteLine("__________________________________");

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 05);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
