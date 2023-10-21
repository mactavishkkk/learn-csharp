using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Student {
        public string name;
        public double noteOne, noteTwo, noteThree;

        public double FinalNote() {
            return noteOne + noteTwo + noteThree;
        }

        public double RemainingPoints() {
            return 60.0 - FinalNote();
        }

        public override string ToString() {
            string status;

            if(FinalNote() >= 60) {
                status = "APROVADO";
            } else {
                status = "REPROVADO \nFALTARAM " + RemainingPoints() + " PONTOS";
            }

            return "NOTA FINAL = " + FinalNote() +
                    "\n" + status;
        }
    }
}
