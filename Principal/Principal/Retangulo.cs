using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
