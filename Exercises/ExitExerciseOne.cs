using System;
using System.Globalization;

namespace PrimeiroProjeto.Exercises
{
    class ExitExerciseOne
    {
        static void MainOff(string[] args)
        {
            string productOne = "Computador", productTwo = "Mesa de escritório";
            byte age = 30;
            int code = 3290;
            char gender = 'M';
            double priceOne = 2100.0, priceTwo = 650.50, measure = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é $ {1:F2} \n{2}, cujo preço é $ {3:F2}\n", productOne, priceOne, productTwo, priceTwo);
            Console.WriteLine("Registro: {0} anos de age, código: {1} e gênero: {2}\n", age, code, gender);
            Console.WriteLine("measure com oito casas decimais: {0:F8}", measure);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", measure);
            Console.WriteLine("Separador decimal: {0}", measure.ToString("", CultureInfo.InvariantCulture));
        }
    }
}
