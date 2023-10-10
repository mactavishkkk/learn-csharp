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

            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um caracter:");
            char caractere = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            double numeroDois = double.Parse(Console.ReadLine()); // 0,00 | CultureInfo.InvariantCulture == 0.00

            Console.WriteLine("Digite o nome, sexo, idade e altura:");
            string[] data = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados digitados: \n Número: {0}\n Caracter: {1}\n Numero Dois: {2}\n" +
                "Dados.nome: {4}\n Dados.sexo: {5}\n Dados.idade: {6}\n Dados.altura: {7}\n", numero, caractere, numeroDois, cor3, data[0], data[1], data[2], data[3]);
        }
    }
}
