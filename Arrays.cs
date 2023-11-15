using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Arrays {
        static void MainOff(string[] args) {
            //Console.WriteLine("Digite quantas heights deseja guardar:");
            //int n = int.Parse(Console.ReadLine());

            //double sum = 0.0;
            //double average = 0.0;

            //double[] heights = new double[n];

            //for (int i = 0; i < n; i++) {
            //    Console.WriteLine("Digite a height {0}:", i + 1);
            //    heights[i] = double.Parse(Console.ReadLine());
            //    sum += heights[i];
            //    average = sum / n;
            //}

            //Console.WriteLine("average - " + average);

            Console.WriteLine("Digite quantos produtos deseja guardar:");
            int n = int.Parse(Console.ReadLine());

            // Product[] produtos = new Product[n];
            double sum = 0.0;
            double average = 0.0;

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o name do produto: ");
                string name = Console.ReadLine();

                Console.Write("Agora digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                // produtos[i] = new Product(name, preco);

                // sum += produtos[i].Price;
                // average = sum / n;
            }

            Console.WriteLine("average - " + average);
        }
    }
}
