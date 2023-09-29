using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class EntryData {
        static void Mainoff(string[] args) {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite uma cor:");
            string cor1 = Console.ReadLine();

            Console.WriteLine("Digite outra cor:");
            string cor2 = Console.ReadLine();

            Console.WriteLine("Digite outra cor:");
            string cor3 = Console.ReadLine();

            Console.WriteLine("Digite 3 (três) cores:");
            string[] cores = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados digitados: \n Frase: {0}\n Cor1: {1}\n Cor2: {2}\n Cor3: {3}\n" +
                "Cores1: {4}\n Cores2: {5}\n Cores3: {6}\n", frase, cor1, cor2, cor3, cores[0], cores[1], cores[2]);
        }
    }
}
