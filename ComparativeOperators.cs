using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class ComparativeOperators {
        static void Main(string[] args) {
            int a = 10;

            bool conditional = a > 10;
            bool conditional1 = a < 10;
            bool conditional2 = a == 10;
            bool conditional3 = a >= 10;
            bool conditional4 = a <= 10;

            Console.WriteLine(conditional);
            Console.WriteLine(conditional1);
            Console.WriteLine(conditional2);
            Console.WriteLine(conditional3);
            Console.WriteLine(conditional4);

            bool conditional5 = a < 10 || a >= 10;
            bool conditional6 = a < 10 && a >= 10;

            Console.WriteLine(conditional5);
            Console.WriteLine(conditional6);
        }
    }
}
