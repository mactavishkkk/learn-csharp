using System;
using System.Globalization;

namespace PrimeiroProjeto.Exercises {
    class EntryExitExerciseOne {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu name completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último name, idade e altura(mesma linha):");
            string[] data = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados Digitados:\n name: {0}\n Quartos: {1}\n Preço: {2:F2}\n" + 
              "Dados.name: {3}\n Dados.idade: {4}\n Dados.altura: {5}\n", name, room, price, data[0], data[1], data[2]);
        }
    }
}
