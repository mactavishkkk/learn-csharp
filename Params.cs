using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Params {

        /* Solução Ruim
         * | int soma = Params.Soma(1, 2, 3);
         * 
         */
        public int Soma(int a, int b, int c) {
            return a + b + c;
        }

        // | int soma = Params.Soma(1, 2);
        public int Soma(int a, int b) {
            return a + b;
        }

        /* Solução Mediana
         * int soma = Params.Soma(new int[] { 1, 2, 3 });
         * public int Soma(int[] numbers) {
         *  int sum = 0;
         *
         *  for (int i = 0; i < numbers.Length; i++) {
         *      sum += numbers[i];
         *  }
         *
         *  return sum;
        } | int soma = Params.Soma(1, 2, 3);
        */

        /*
         * Solução Boa
         * int soma = Params.Soma(1, 2, 3);
        */
        public int Soma(params int[] numbers) {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            return sum;
        }

        /* int a = 10;
        * Params.Triplo(a);
        * Console.Write(a); | 10 */
        public void Triplo(int x) {
            x *= 3;
        }

        /* int a = 10;
        * Params.Triplo(ref a);
        * Console.Write(a); | 30 */
        public void Triplo(ref int x) {
            x *= 3;
        }

        /* int a = 10;
         * int b;
        * Params.Triplo(a, out b);
        * Console.Write(a); | 30 */
        public void Triplo(int origin, out int result) {
            result = origin * 3;
        }
    }
}
