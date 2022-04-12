using System;
using System.Collections.Generic;
using ExercicioFMetodo_Abstrato.Entities;
using System.Globalization;

namespace ExercicioFMetodo_Abstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payers> list = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n + 1; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine());

                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine());

                    Console.Write("Number of employees: ");
                    int employeer = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, employeer));
                }

            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;

            foreach (Payers payer in list)
            {
                double tx = payer.Taxes();
                Console.WriteLine(payer.Name + ": $" + payer.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += tx;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
