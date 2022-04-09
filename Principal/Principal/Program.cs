using System;
using System.Globalization;

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + r.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Perimetro: " + r.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
