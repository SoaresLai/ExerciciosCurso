using Funcionarios.Intities;
using Funcionarios.Intities.Enums;
using System;
using System.Globalization;

namespace Funcionario
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department name: ");
            string deptName = Console.ReadLine();

            Console.Write("Enter worker data: (DD/MM/YYYY)");
            DateTime workerDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/Senior/Pleno): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker (name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++ )
            {
                Console.Write($"#Enter # {i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours) ;
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
