namespace PrimeiroProjeto.Classes.Worker.Enums;

internal class Worker
{
    public string Name;
    private WorkerLevel Level;
    private double BaseSalary;
    public Department Department { get; set; }
    private List<HourContract> Contracts { get; set; } = new List<HourContract>();

    public Worker() { }

    public Worker(string name, WorkerLevel level, double salary, Department department)
    {
        Name = name;
        Level = level;
        BaseSalary = salary;
        Department = department;
    }

    public void AddContract(HourContract contract)
    {
        Contracts.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
        Contracts.Remove(contract);
    }

    public double Income(int year, int month)
    {
        double totalSalary = BaseSalary;

        foreach (HourContract contract in Contracts)
        {
            if (contract.Date.Year == year && contract.Date.Month == month)
            {
                totalSalary += contract.TotalValue();
            }
        }

        return totalSalary;
    }
}
