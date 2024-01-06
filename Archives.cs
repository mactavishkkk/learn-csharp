using System;
using System.IO;

namespace PrimeiroProjeto
{
    internal class Archives
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mac\Documents\projetos\design-armazonico";

            try
            {
                var folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine();

                Directory.CreateDirectory(sourcePath + @"\newFolder\file.txt");

            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
