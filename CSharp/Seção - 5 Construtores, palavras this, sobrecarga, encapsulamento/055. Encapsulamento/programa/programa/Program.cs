﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);


            p.SetNome("t");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            
        }
    }
}