using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            DateTime dia1 =  DateTime.Now;

            Console.WriteLine(dia1);
            Console.WriteLine(dia1.Ticks);
            Console.WriteLine("-----------");
            
            DateTime d1 = new DateTime(2018,11,25);
            DateTime d2 = new DateTime(2021, 06, 04, 12, 55, 01);
            DateTime d3 = new DateTime(2021, 06, 04, 12, 55, 01, 500);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow; // Horario universal

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine("-----------");

            // usando o parse p/ gerar as datas  -> padrao

            DateTime d7 = DateTime.Parse("2000-06-04"); 
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-06-04 13:05:58"); 
            Console.WriteLine(d8);

            // padrao brasileiro
            DateTime d9 = DateTime.Parse("15/05/2020");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("15/05/2020 13:05:00");
            Console.WriteLine(d10);

            // Voce quer determinar o formato da sua data

            DateTime d11 = DateTime.ParseExact("2000-08-05","yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/05/2020 13:05:01","dd-MM-yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            Console.WriteLine(d11);
            Console.WriteLine(d12);

        }
    }
}
