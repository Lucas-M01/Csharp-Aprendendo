using System;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            
            Console.Write("Quantos dólares você vai comprar? ");
            int quant = int.Parse(Console.ReadLine());

            
            double pagar = ConversorDeMoeda.Porcent(dolar, quant);

            Console.WriteLine("Valor a ser pago em reais = " + pagar.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
