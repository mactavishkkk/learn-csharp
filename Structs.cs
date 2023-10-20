using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Structs {
        static void Main(string[] args) {
            //Point p; Incorreto
            //Console.WriteLine(p);

            Point p = new Point();
            Console.WriteLine(p);

            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;
            Console.WriteLine(p1);
        }
    }
}
