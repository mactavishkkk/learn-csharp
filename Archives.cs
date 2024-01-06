using System;
using System.IO;

namespace PrimeiroProjeto
{
    internal class Archives
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mac\Documents\projetos\PrimeiroProjeto\PrimeiroProjeto\file.txt";

            try
            {
                using (StreamReader SR = File.OpenText(path))
                {
                    while (!SR.EndOfStream)
                    {
                        string line = SR.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
