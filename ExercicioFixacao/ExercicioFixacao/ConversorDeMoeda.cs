using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao
{
    internal class ConversorDeMoeda
    {


        public static double Porcent(double dolar, int quant)
        {
            return ((dolar * 0.06) * quant) + (quant * dolar);
        }
    }
}
