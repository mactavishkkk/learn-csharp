namespace PrimeiroProjeto
{
    internal class Exceptions
    {
        static void MainOff(string[] args)
        {
            try
            {
                Console.WriteLine("Divisão de números!");

                Console.Write("Digite o 1° número: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Digite o 2° número: ");
                int numberOne = int.Parse(Console.ReadLine());

                Console.WriteLine(number / numberOne);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível dividir por '0', Erro: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Não é possível executar esta operações com letras, Erro: " + ex.Message);
            }
        }
    }
}
