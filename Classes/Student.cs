using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Student {
        public string nome;
        public double notaUm, notaDois, notaTres;

        public double NotaFinal() {
            return notaUm + notaDois + notaTres;
        }

        public double PontosRestantes() {
            return 60.0 - NotaFinal();
        }

        public override string ToString() {
            string status;

            if(NotaFinal() >= 60) {
                status = "APROVADO";
            } else {
                status = "REPROVADO \nFALTARAM " + PontosRestantes() + " PONTOS";
            }

            return "NOTA FINAL = " + NotaFinal() +
                    "\n" + status;
        }
    }
}
