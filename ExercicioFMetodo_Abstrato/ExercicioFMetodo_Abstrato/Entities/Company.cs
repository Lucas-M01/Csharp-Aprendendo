namespace ExercicioFMetodo_Abstrato.Entities
{
    internal class Company : Payers
    {
        public int NumberEmployers { get; set; }

        
        public Company(string name, double anualIncome,int numberEmployers) : base(name,anualIncome)
        {
            NumberEmployers = numberEmployers;
        }

        public override double Taxes()
        {
            if(NumberEmployers > 14)
            {
                return (AnualIncome * 0.14);
            }
            else
            {
                return (AnualIncome * 0.16);
            }
        }
    }
}
