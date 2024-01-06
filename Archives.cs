using System;
using System.IO;

namespace PrimeiroProjeto
{
    internal class Archives
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mac\Documents\projetos\PrimeiroProjeto\PrimeiroProjeto\fileOne.txt";
            string targetPath = @"C:\Users\mac\Documents\projetos\PrimeiroProjeto\PrimeiroProjeto\file.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
