using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Arrays {
        static void Main(string[] args) {
            //Console.WriteLine("Digite quantas alturas deseja guardar:");
            //int n = int.Parse(Console.ReadLine());

            //double soma = 0.0;
            //double media = 0.0;

            //double[] alturas = new double[n];

            //for (int i = 0; i < n; i++) {
            //    Console.WriteLine("Digite a altura {0}:", i + 1);
            //    alturas[i] = double.Parse(Console.ReadLine());
            //    soma += alturas[i];
            //    media = soma / n;
            //}

            //Console.WriteLine("MEDIA - " + media);

            Console.WriteLine("Digite quantos produtos deseja guardar:");
            int n = int.Parse(Console.ReadLine());

            Product[] produtos = new Product[n];
            double soma = 0.0;
            double media = 0.0;

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Agora digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                produtos[i] = new Product(nome, preco);

                soma += produtos[i].Preco;
                media = soma / n;
            }

            Console.WriteLine("MEDIA - " + media);
        }
    }
}
