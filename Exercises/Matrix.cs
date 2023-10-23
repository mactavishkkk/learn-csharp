using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises {
    class Matrix {
        static void Main(string[] args) {
            Console.Write("Digite o tamanho da sua matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite os elementos para a linha {0}: ", i);
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            int negativeNumbers = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrix[i, j] < 0) {
                        negativeNumbers++;
                    }
                }
            }

            Console.Write("Quantidade de números negativos: " + negativeNumbers);
        }
    }
}
