using System;
using ExercicioClassesMetodosAbstratos02.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioClassesMetodosAbstratos02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Taxpayer> list = new List<Taxpayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthSpending));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employees));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID: ");
            foreach (Taxpayer payer in list){
                Console.WriteLine(payer.Name + ": $ " + payer.TaxesValue().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
