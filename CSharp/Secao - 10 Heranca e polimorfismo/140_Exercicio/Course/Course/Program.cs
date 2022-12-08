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
            Console.Write("Enter the number of employees: ");
            int qtdEmployees = int.Parse(Console.ReadLine());

            List<Employee> emp = new List<Employee>();
            
            for(int i = 1; i <= qtdEmployees; i++)
            {

                Console.Write("Outsourced (y/n)? ");
                string answer = Console.ReadLine();

                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(answer == "y")
                {
                    Console.Write("Additional charge: ");
                    double additonal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    emp.Add(new OutsourcedEmployee(name,hour, valuePerHour, additonal));
                }
                else
                {
                    emp.Add(new Employee(name, hour, valuePerHour));
                }

            }

            Console.WriteLine("Payments: ");
            foreach(Employee element in emp)
            {
                Console.WriteLine(element.Name +" - $ "+element.Payment().ToString("F2", CultureInfo.InvariantCulture) );
            }

        }
    }
}
