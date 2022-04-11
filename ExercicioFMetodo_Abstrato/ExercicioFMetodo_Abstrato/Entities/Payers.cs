namespace ExercicioFMetodo_Abstrato.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();

    }
}
