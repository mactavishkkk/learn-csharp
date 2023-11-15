using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Lists {
        static void MainOff(string[] args) {
            List<string> list = new List<string>();

            List<string> listTwo = new List<string> { "Maria", "Alex", "Bob" };

            list.Add("Mario");
            list.Add("Alexa");
            list.Add("Bruna");
            list.Insert(2, "Paulo");

            foreach (string i in list) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Tamanho da list: " + list.Count);

            string initialNameB = list.Find(InicioB);
            // string initialNameB = list.Find(x => x[0] == 'B');
            Console.WriteLine("Primeiro name que comece com 'B': " + initialNameB);

            //string initialNameA = list.FindLast(InicioB);
            string initialNameA = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último name que comece com 'A': " + initialNameA);

            int indiceInicioB = list.FindIndex(InicioB);
            // int initialNameB = list.FindIndex(x => x[0] == 'B');
            Console.WriteLine("Primeiro índice que comece com 'B': " + indiceInicioB);

            //int initialNameA = list.FindLastIndex(InicioB);
            int indiceInicioA = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Último índice que comece com 'A': " + indiceInicioA);

            List<string> listFilter = listTwo.FindAll(nameCurto);
            foreach (string i in listFilter) {
                Console.WriteLine(i);
            }

            list.Remove("Paulo"); // | Mario, Alexa, Bruna
            list.RemoveAll(x => x[0] != 'B'); // | Bruna
            list.RemoveAt(1); // | Alexa, Bruna, Paulo
            list.RemoveRange(0, 2); // | Bruna, Paulo
        }

        static bool InicioB(string str) {
            return str[0] == 'B';
        }

        static bool nameCurto(string str) {
            return str.Length < 5;
        }
    }
}
