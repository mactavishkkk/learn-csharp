﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class RepetitionStructure {
        static void MainOff(string[] args) {
            Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            while (number >= 0) {
                Console.WriteLine(Math.Sqrt(number));

                Console.Write("Digite outro número: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }

            Console.WriteLine("Número negativo, programa encerrado");

            Console.Write("Digite quantos números inteiros você deseja guardar: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < N; i++) {
                Console.Write("Valor #{0}:", i + 1);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("sum: " + sum);

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
