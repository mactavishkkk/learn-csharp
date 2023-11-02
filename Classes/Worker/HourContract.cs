using System;

namespace PrimeiroProjeto.Classes.Worker
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }
        public HourContract(DateTime date, double valueHour, int hours)
        {
            Date = date;
            ValuePerHour = valueHour;
            Hours = hours;
        }

        public double TotalValue() { return Hours * ValuePerHour; }
    }
}
