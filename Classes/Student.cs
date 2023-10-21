using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Student {
        public string Name;
        public double NoteOne, NoteTwo, NoteThree;

        public double FinalNote() {
            return NoteOne + NoteTwo + NoteThree;
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
