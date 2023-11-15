using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class ComparativeOperators {
        static void MainOff(string[] args) {
            int a = 10;

            bool conditional = a > 10;
            bool conditionalOne = a < 10;
            bool conditionalTwo = a == 10;
            bool conditionalThree = a >= 10;
            bool conditionalFour = a <= 10;

            Console.WriteLine(conditional);
            Console.WriteLine(conditionalOne);
            Console.WriteLine(conditionalTwo);
            Console.WriteLine(conditionalThree);
            Console.WriteLine(conditionalFour);

            bool conditionalFive = a < 10 || a >= 10;
            bool conditionalSix = a < 10 && a >= 10;

            Console.WriteLine(conditionalFive);
            Console.WriteLine(conditionalSix);
        }
    }
}
