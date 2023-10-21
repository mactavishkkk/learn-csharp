using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises {
    internal class Lists {
        static void Main(string[] args) {
            Console.Write("Quantos funcionários você deseja registrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("\n");
                Console.WriteLine("Funcionário #{0}", i + 1);

                Console.Write("Codigo: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string Name = Console.ReadLine();

                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, Name, salary));
            }

            Console.WriteLine("\nLista de funcionários: \n");
            foreach (Employee i in employees) {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n<------>\n");

            Console.Write("Digite o código do funcionário que deseja realizar um aumento: ");
            int code = int.Parse(Console.ReadLine());

            Employee luckBoy = employees.Find(x => x._id == code);
            if (luckBoy == null) {
                Console.WriteLine("Este funcionário não existe");

                Console.WriteLine("\nLista de funcionários: \n");
                foreach (Employee i in employees) {
                    Console.WriteLine(i);
                }

            } else {
                Console.Write("Digite quantos poncento: ");
                double percentage = double.Parse(Console.ReadLine());

                luckBoy.IncreaseSalary(percentage);

                Console.WriteLine("\nLista de funcionários: \n");
                foreach (Employee i in employees) {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
