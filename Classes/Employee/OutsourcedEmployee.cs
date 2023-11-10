using System.Xml.Linq;

namespace PrimeiroProjeto.Classes.Employee
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double basePayment = base.Payment();
            basePayment += AdditionalCharge * 1.1;
            return basePayment;
        }
    }
}
