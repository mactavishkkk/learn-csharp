using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Mainoff(string[] args)
        {
            char gender = 'F';
            int age = 30;
            double sale = 10.5676;
            string name = "Maria Silva";

            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(sale.ToString("F2"));
            Console.WriteLine(sale.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(name + "\n");

            Console.Write(name); Console.Write(" tem "); Console.Write(age); Console.Write(" anos e seu saldo é igual há: "); Console.Write(age + "\n");
            Console.WriteLine("{0} tem {1} anos e seu saldo é igual há: {2:F2}", name, age, sale);
            Console.WriteLine($"{name} tem {age} anos e seu saldo é igual há: {sale}");
            Console.Write(name + " tem " + age + " anos e seu saldo é igual há: " + sale);
        }
    }
}