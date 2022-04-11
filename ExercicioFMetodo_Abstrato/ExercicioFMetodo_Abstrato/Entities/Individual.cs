using System;
using ExercicioFMetodo_Abstrato.Entities;

namespace ExercicioFMetodo_Abstrato.Entities
{
    internal class Individual : Payers
    {
        public double Health { get; set; }

        public Individual(string name, double anualIncome, double health) : base(name, anualIncome)
        {
            Health = health;
        }

        public override double Taxes()
        {
            if (AnualIncome > 20000.00)
            {
                return (AnualIncome * 0.25) - (Health * 0.5); 
            }
            else
            {
                return (AnualIncome * 0.15) - (Health * 0.5);
            }
        }
    }
}
