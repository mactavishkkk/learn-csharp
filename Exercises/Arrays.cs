using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercises {
    class Arrays {
        static void MainOff(string[] args) {
            Console.Write("Quantos quartos serão alugados? ");
            int roomNumbers = int.Parse(Console.ReadLine());

            RentStudent[] renteds = new RentStudent[10];

            for (int i = 0; i < roomNumbers; i++) {
                Console.WriteLine("Alugel {0}:", i + 1);
                Console.Write("Digite o name do estudante: ");
                string name = Console.ReadLine();

                Console.Write("Digite o email do estudante: ");
                string email = Console.ReadLine();

                Console.Write("Digite o número do quarto de 0 a 9: ");
                int room = int.Parse(Console.ReadLine());

                renteds[room] = new RentStudent(name, email, room);
            }

            // Console.WriteLine("Quartos Alugados: ");
            // for (int i = 0; i < renteds.Length; i++) {
            //     if (renteds[i] != null)
            //         Console.WriteLine("{0}: {1}, {2}", renteds[i].Quarto, renteds[i].Name, renteds[i].Email);
            // }
        }
    }
}
