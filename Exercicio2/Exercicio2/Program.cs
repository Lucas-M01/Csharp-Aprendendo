using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();
            
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + p);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para o aumento do salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
