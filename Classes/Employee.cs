using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Employee {
        public string name;
        public double salary;
        public double tax;

        public double LiquidSalary() {
            return salary - tax;
        }

        public void IncreaseSalary(double porcentagem) {
            double aumento = salary * (porcentagem / 100);
            salary += aumento;
        }

        public override string ToString() {
            return "Funcionário: " + name + " $ " + LiquidSalary();
        }
    }
}
