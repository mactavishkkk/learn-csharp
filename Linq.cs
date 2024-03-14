using PrimeiroProjeto.Classes.Product;

namespace PrimeiroProjeto
{
    internal class Linq
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "hardware", Tier = 3 };
            Category c3 = new Category() { Id = 3, Name = "clothes", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 3, Name = "Hammer", Price = 100.0, Category = c1 },
                new Product() { Id = 4, Name = "Chainsaw", Price = 900.0, Category = c1 },
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Laptop", Price = 2100.0, Category = c2 },
                new Product() { Id = 5, Name = "T-shirt", Price = 50.0, Category = c3 },
                new Product() { Id = 6, Name = "hat", Price = 30.0, Category = c3 },
            };

            var result = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("Tier 1 and Price < 900", result);

            var resultOne = products.Where(p => p.Category.Name == "tools").Select(p => p.Name);
            Print("Only name from tools", resultOne);

            var resultThree = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, Category = p.Category.Name });
            Print("Only initial 'C' and name, price and category", resultThree);

            var resultFour = products.Where(p => p.Id == 3).Single(); // if p == null ?? Exception
            var resultFeve = products.Where(p => p.Id == 3).SingleOrDefault(); // if p == null ?? null

            var resultMax = products.Max(p => p.Price);
            Console.WriteLine("Max product price: " + resultMax);

            var resultMin = products.Min(p => p.Price);
            Console.WriteLine("Max product price: " + resultMin);

        }

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
