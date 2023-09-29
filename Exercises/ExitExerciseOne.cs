using System;
using System.Globalization;

namespace PrimeiroProjeto.Exercises {
    class ExitExerciseOne {
        static void Main(string[] args) {
            string produto1 = "Computador", produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 3290;
            char genero = 'M';
            double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é $ {1:F2} \n{2}, cujo preço é $ {3:F2}\n", produto1, preco1, produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, código: {1} e gênero: {2}\n", idade, codigo, genero);
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal: {0}", medida.ToString("", CultureInfo.InvariantCulture));
        }
    }
}
