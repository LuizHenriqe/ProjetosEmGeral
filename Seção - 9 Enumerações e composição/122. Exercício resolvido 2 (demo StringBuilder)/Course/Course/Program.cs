using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name =Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            
            Console.Write("BAse salary: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture   );

            Department dept = new Department(deptName);

            Worker worker = new Worker(name,level,basesalary,dept);

            Console.Write("how many contracts to  this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i < n; i++)
            {
                Console.WriteLine($"Enter  #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (HOurs): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);

            }

        }
    }
}
