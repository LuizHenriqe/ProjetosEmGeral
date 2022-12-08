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
            List<Pessoa> listPessoa = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int qtdPayers= int.Parse(Console.ReadLine());

            for(int i =1; i<= qtdPayers;i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                string r = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());


                if(r.ToLower() == "i")
                {
                    Console.Write("Health expenditures: ");
                    double he = double.Parse(Console.ReadLine());

                    listPessoa.Add(new PF(name, anualIncome,he));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int qtdPeople = int.Parse(Console.ReadLine());

                    listPessoa.Add(new PJ(name,anualIncome,qtdPeople));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Pessoa ps in listPessoa)
            {
                Console.WriteLine(ps.CalcImpostoRet());
            }

            double taxasTotal= 0;

            foreach(Pessoa ps in listPessoa)
            {
                taxasTotal += ps.CalculaRenda(); 
            }

            Console.WriteLine($"Total Taxes: $ {taxasTotal.ToString("F2")}");
        }
    }
}
