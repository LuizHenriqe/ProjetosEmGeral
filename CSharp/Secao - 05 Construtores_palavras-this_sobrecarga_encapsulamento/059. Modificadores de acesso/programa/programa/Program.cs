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
            p.Quantidade +=  -5;
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine(p.Nome);
            Cons\ole.WriteLine(p.Preco);
            
        }
    }
}