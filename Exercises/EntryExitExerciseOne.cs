using System;
using System.Globalization;

namespace PrimeiroProjeto.Exercises {
    class EntryExitExerciseOne {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura(mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados Digitados:\n Nome: {0}\n Quartos: {1}\n Preço: {2:F2}\n" + 
              "Dados.nome: {3}\n Dados.idade: {4}\n Dados.altura: {5}\n", nome, quartos, preco, dados[0], dados[1], dados[2]);
        }
    }
}
