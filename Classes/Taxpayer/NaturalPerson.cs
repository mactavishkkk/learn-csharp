namespace PrimeiroProjeto.Classes.Taxpayer
{
    internal class NaturalPerson : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson() { }

        public NaturalPerson(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double taxe = 0.0;
            double healthTaxe = 0.0;

            if (HealthExpenditures > 0)
            { healthTaxe = HealthExpenditures * 0.50; }

            if (AnnualIncome < 20000.00)
            { taxe = 0.15; } else { taxe = 0.25; }

            return (AnnualIncome * taxe) - healthTaxe;
        }
    }
}
