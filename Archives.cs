using System;
using System.IO;

namespace PrimeiroProjeto
{
    internal class Archives
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mac\Documents\projetos\PrimeiroProjeto\PrimeiroProjeto\file.txt";
            FileStream FS = null;
            StreamReader SR = null;
            try
            {
                FS = new FileStream(path, FileMode.Open);
                SR = new StreamReader(FS);
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    Console.WriteLine(line);
                }

            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally
            {
                if (SR != null) SR.Close();
                if (FS != null) FS.Close();
            }
        }
    }
}
