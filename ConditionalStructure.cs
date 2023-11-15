using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class ConditionalStructure {
        static void MainOff(string[] args) {
            Console.WriteLine("Digite que hours são: ");
            int hours = int.Parse(Console.ReadLine());

            if (hours > 06 && hours < 12)
                Console.WriteLine("Bom dia!");

            if (hours > 12 && hours < 18) {
                Console.WriteLine("Boa Tarde!");
            } else if (hours > 18 && hours < 06) {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
