namespace PrimeiroProjeto.Exercises
{
    internal class StudentSet
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();

            Console.Write("Quantos estudantes para o curso A? ");
            int cA = int.Parse(Console.ReadLine());

            for(int i = 0; i < cA; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);

            }
            
            Console.Write("Quantos estudantes para o curso B? ");
            int cB = int.Parse(Console.ReadLine());

            for (int i = 0; i < cB; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            Console.Write("Quantos estudantes para o curso C? ");
            int cC = int.Parse(Console.ReadLine());

            for (int i = 0; i < cC; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            Console.WriteLine("Total de estudantes: " + courseA.Count());
        }
    }
}
