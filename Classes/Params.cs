using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes
{
    class Params
    {

        /* Bad Solution
         * | int sum = Params.Sum(1, 2, 3);
         * 
         */
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // | int sum = Params.Sum(1, 2);
        public int Sum(int a, int b)
        {
            return a + b;
        }

        /* Mid Solution
         * int sum = Params.Sum(new int[] { 1, 2, 3 });
         * public int Sum(int[] numbers) {
         *  int sum = 0;
         *
         *  for (int i = 0; i < numbers.Length; i++) {
         *      sum += numbers[i];
         *  }
         *
         *  return sum;
        } | int sum = Params.sum(1, 2, 3);
        */

        /*
         * Good Solution
         * int sum = Params.Sum(1, 2, 3);
        */
        public int Sum(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        /* int a = 10;
        * Params.Triple(a);
        * Console.Write(a); | 10 */
        public void Triple(int x)
        {
            x *= 3;
        }

        /* int a = 10;
        * Params.Triple(ref a);
        * Console.Write(a); | 30 */
        public void Triple(ref int x)
        {
            x *= 3;
        }

        /* int a = 10;
         * int b;
        * Params.Triple(a, out b);
        * Console.Write(a); | 30 */
        public void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
