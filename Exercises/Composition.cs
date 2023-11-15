using PrimeiroProjeto.Classes.Worker;
using PrimeiroProjeto.Classes.Worker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises
{
    class Composition
    {
        static void MainOff(string[] args)
        {
            string name;
            double baseSalary;

            Console.WriteLine("Preencha os dados a seguir: ");
            Console.Write("Digite o nome do departamento: ");
            Department department = new Department(Console.ReadLine());

            Console.Write("Digite o nome do funcionário: ");
            name = Console.ReadLine();
            Console.Write("Digite o level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Digite o salário base: ");
            baseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(name, level, baseSalary, department);

            Console.WriteLine("Digite quantos contratos ele possui: ");
            int contractsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < contractsNumber; i++)
            {
                Console.WriteLine($"Digite os dados do contrato #{i + 1}: ");

                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor hora: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Duração (hrs): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("Digite o mês e o ano para calcular a renda total (MM/YYYY): ");
            string incomeDate = Console.ReadLine();

            int month = int.Parse(incomeDate.Substring(0, 2));
            int year = int.Parse(incomeDate.Substring(3));

            Console.WriteLine("Nome: {0}\nDepartamento: {1}\nRenda para {2}: {3}",
                worker.Name, worker.Department.Name, incomeDate, worker.Income(month, year));
        }
    }
}
