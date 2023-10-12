using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Employee {
        public string nome;
        public double salario;
        public double imposto;

        public double SalarioLiquido() {
            return salario - imposto;
        }

        public void AumentarSalario(double porcentagem) {
            double aumento = salario * (porcentagem / 100);
            salario += aumento;
        }

        public override string ToString() {
            return "Funcionário: " + nome + " $ " + SalarioLiquido();
        }
    }
}
