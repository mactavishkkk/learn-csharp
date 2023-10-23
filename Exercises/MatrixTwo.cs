using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises {
    class matrixrixTwo {
        static void Main(string[] args) {
            Console.Write("Digite o número de linhas da sua matrixriz: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da sua matrixriz: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++) {
                Console.WriteLine("Digite os valores da linha {0}: ", i);
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++) {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            string position = "";

            Console.Write("Digite um valor da matrixriz que deseja buscar: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < r; i++) {
                for (int j = 0; j < c; j++) {
                    if (matrix[i, j] == n) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        if (j < c - 1) {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }
                        if (i < r - 1) {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
