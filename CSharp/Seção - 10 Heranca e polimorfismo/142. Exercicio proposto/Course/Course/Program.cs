using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int respostaQtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= respostaQtd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string respostaType = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(respostaType == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(respostaType == "u")
                {
                    Console.Write("Manufacture date: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    list.Add(new Product(name, price));

                }
            }

            Console.WriteLine();
            Console.WriteLine("Price tags:");
            foreach(Product pt in list)
            {
                Console.WriteLine(pt.PriceTag());
            }
        }
    }
}
