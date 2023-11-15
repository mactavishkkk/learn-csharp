using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class TriangleArea {
        static void MainOff(string[] args) {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do primeiro triângulo: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do segundo triângulo: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());


            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
        }
    }
}
