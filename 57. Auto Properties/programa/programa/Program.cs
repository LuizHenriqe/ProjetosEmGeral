using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "Thanks";
            
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            
        }
    }
}