using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2020, 6, 10,07,03,10,275);
            Console.WriteLine(d);

            Console.WriteLine("1) Date: "+ d.Date);
            Console.WriteLine("2) Day: "+ d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond? " + d.Millisecond);
            Console.WriteLine("8) Minute: "+ d.Minute);
            Console.WriteLine("9) Month: "+ d.Month);
            Console.WriteLine("10) Second: "+ d.Second);
            Console.WriteLine("11) Ticks: "+ d.Ticks);
            Console.WriteLine("12) Year: "+ d.Year);


            DateTime d1 = new DateTime(2020, 6, 10, 07, 03, 10);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            //imprime o formato padrao
            string s5 = d.ToString(); 
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff"); // com milissigundos
            

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //adicionas ou subtrair os valores entre eles

            DateTime d2 = d1.AddHours(20);
            DateTime d3 = d1.AddMinutes(3);


            Console.WriteLine("Add Hours: "+ d2);
            Console.WriteLine("Add Minutes : "+ d3);

            // exemplo de vencimento de boleto
            DateTime dataAgora = DateTime.Now;

            DateTime AddDateTime = dataAgora.AddDays(7); // adiciona 7 dias
            Console.WriteLine(AddDateTime);

            // dfirerença data 

            DateTime data1 = new DateTime(2021,06,01);
            DateTime data2 = new DateTime(2021,06,10);

            TimeSpan ResultDate = data2.Subtract(data1);

            Console.WriteLine(ResultDate.Days);

        }
    }
}
