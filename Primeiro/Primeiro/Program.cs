using System;
using System.Globalization;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome e o salário do primeiro funcionario: ");
            pessoa1.nome = Console.ReadLine();
            pessoa1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome e o salário de um segundo funcionario: ");
            pessoa2.nome = Console.ReadLine();
            pessoa2.salario = double.Parse(Console.ReadLine());

            double media = (pessoa1.salario + pessoa2.salario)/2;

            Console.WriteLine("--------=---------");
            Console.WriteLine($"Média salarial é de: {media:F2}");
        }
    }
}
