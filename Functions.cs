using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class Functions {
        static int Bigger(int a, int b, int c) {
            if (a > b && a > c) {
                return a;
            } else if (b > c) {
                return b;
            } else {
                return c;
            }
        }

        static void MainOff(string[] args) {
            Console.WriteLine("Digite 3 numeros: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int result = Bigger(numberOne, numberTwo, numberThree);
            Console.WriteLine(result);
        }
    }
}
