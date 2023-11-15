using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Matrices {
        static void MainOff(string[] args) {
            double[,] matrix = new double[2, 3];

            Console.WriteLine(matrix.Length); // Total items
            Console.WriteLine(matrix.Rank); // Total rows
            Console.WriteLine(matrix.GetLength(0)); // Total rows (0) or columns (1)
        }
    }
}
