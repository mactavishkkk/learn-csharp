using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class ConditionalStructure {
        static void Main(string[] args) {
            Console.WriteLine("Digite que horas são: ");
            int horas = int.Parse(Console.ReadLine());

            if (horas > 06 && horas < 12)
                Console.WriteLine("Bom dia!");

            if (horas > 12 && horas < 18) {
                Console.WriteLine("Boa Tarde!");
            } else if (horas > 18 && horas < 06) {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
