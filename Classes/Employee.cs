using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Employee {
        public int _id;
        public string Name;
        private double _salary;
        public double Tax;
        
        public Employee(int id, string name, double salary) {
            _id = id;
            Name = name;
            _salary = salary;
        }

        public double LiquidSalary() {
            return _salary - Tax;
        }

        public void IncreaseSalary(double percentage) {
            double increase = _salary * (percentage / 100);
            _salary += increase;
        }

        public override string ToString() {
            return "Funcionário: " + _id + ", Nome: " + Name + ", Salário: $ " + _salary;
        }
    }
}
