namespace PrimeiroProjeto.Classes.Taxpayer
{
    internal class LegalEntity : Taxpayer
    {
        public int NumberEmployees { get; set; }

        public LegalEntity() { }

        public LegalEntity(string name, double annualIncome, int numberEmployees)
            : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Taxes()
        {
            double taxe = 0.0;

            if (NumberEmployees > 10)
            { taxe = 0.14; } else { taxe = 0.16; }

            return AnnualIncome * taxe;
        }
    }
}
