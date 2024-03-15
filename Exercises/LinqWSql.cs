using PrimeiroProjeto.Classes.Order;

namespace PrimeiroProjeto.Exercises
{
    internal class LinqWSql
    {
        static void MainOff(string[] args)
        {
            Console.WriteLine("Enter a full file path: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1]);
                    products.Add(new Product(name, price));
                }
            }

            var averagePrice = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + averagePrice.ToString("F2"));

            var names = products.Where(p => p.Price < averagePrice)
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name);

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
