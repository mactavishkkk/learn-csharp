using System;

namespace PrimeiroProjeto {
    class Types {
        static void Mainoff(string[] args) {
            sbyte x = 10;

            Console.WriteLine(x);

            bool boolean = false;
            
            char character = 'a';
            char unicode = '\u0041';
            string name = "Isaías Leite";
            
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 69.61f;
            
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;

            object objOne = "Hello";
            object objTwo = 123;
            object objThree = true;

            Console.WriteLine(boolean);

            Console.WriteLine(character);
            Console.WriteLine(unicode);
            Console.WriteLine(name);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);

            Console.WriteLine(objOne);
            Console.WriteLine(objTwo);
            Console.WriteLine(objThree);
        }
    }
}