using System;
using System.Globalization;
using System.IO;

namespace PrimeiroProjeto.Exercises
{
    internal class Archives
    {
        static void MainOff(string[] args)
        {
            string path = @"C:\Users\mac\Documents\projetos\PrimeiroProjeto\PrimeiroProjeto\OtherFiles\products_input.csv";
            string targetPath = @"C:\Users\mac\Documents\projetos\PrimeiroProjeto\PrimeiroProjeto\OtherFiles\products_output.csv";
            bool archiveExists = File.Exists(path);

            List<string> products = new List<string>
            {
                "TV Led, 1290.99, 1",
                "Video Game, 350.00, 3",
                "Iphone 12, 900, 2",
                "Samsung Galaxy A10, 850.34, 2"
            };

            try
            {
                if (!archiveExists)
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        Console.WriteLine("Arquivo criado!");
                        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                        Console.WriteLine();

                        foreach (string line in products)
                        {
                            sw.WriteLine(line);
                            Console.WriteLine("Produto Adicionado!");
                            Console.WriteLine(line);
                            Console.WriteLine();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Arquivo já existe!");
                    Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                }

                List<string> productsInput = new List<string>();
                List<string> productsOutput = new List<string>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        productsInput.Add(line);
                    }
                }

                foreach (string line in productsInput)
                {
                    string[] data = line.Split(',');

                    int quantity = int.Parse(data[2]);
                    double price = double.Parse(data[1], CultureInfo.InvariantCulture);
                    double totalPrice = quantity * price;

                    productsOutput.Add(data[0] + "," + totalPrice.ToString("F2", CultureInfo.InvariantCulture));
                }

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in productsOutput)
                    {
                        sw.WriteLine(line);
                        Console.WriteLine("Produto Adicionado!");
                        Console.WriteLine(line);
                        Console.WriteLine();
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
