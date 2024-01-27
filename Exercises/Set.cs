using PrimeiroProjeto.Classes;

namespace PrimeiroProjeto.Exercises
{
    internal class Set
    {
        static void Main(string[] args)
        {
            HashSet<LogRegister> set = new HashSet<LogRegister>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRegister { UserName = name, Instant = instant });
                    }
                    Console.WriteLine("File path: " + path);
                    Console.WriteLine("Total users: " + set.Count());
                }
            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
