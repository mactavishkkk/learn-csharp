namespace PrimeiroProjeto.Classes.Taxpayer
{
    internal abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer() { }

        public Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Taxes();
    }
}
