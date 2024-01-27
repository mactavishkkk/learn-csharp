using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class EntryData {
        static void MainOff(string[] args) {
            Console.WriteLine("Digite uma phrase:");
            string phrase = Console.ReadLine();

            Console.WriteLine("Digite uma cor:");
            string colorOne = Console.ReadLine();

            Console.WriteLine("Digite outra cor:");
            string colorTwo = Console.ReadLine();

            Console.WriteLine("Digite outra cor:");
            string colorThree = Console.ReadLine();

            Console.WriteLine("Digite 3 (três) colors:");
            string[] colors = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados digitados: \n phrase: {0}\n colorOne: {1}\n colorTwo: {2}\n colorThree: {3}\n" +
                "colors1: {4}\n colors2: {5}\n colors3: {6}\n", phrase, colorOne, colorTwo, colorThree, colors[0], colors[1], colors[2]);

            Console.WriteLine("Digite um número:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um caracter:");
            char character = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            double numberTwo = double.Parse(Console.ReadLine()); // 0,00 | CultureInfo.InvariantCulture == 0.00

            Console.WriteLine("Digite o name, sexo, age e height:");
            string[] data = Console.ReadLine().Split(' ');

            Console.WriteLine("Dados digitados: \n Número: {0}\n Caracter: {1}\n number Dois: {2}\n" +
                "Dados.name: {4}\n Dados.sexo: {5}\n Dados.age: {6}\n Dados.height: {7}\n", number, character, numberTwo, colorThree, data[0], data[1], data[2], data[3]);
        }
    }
}
