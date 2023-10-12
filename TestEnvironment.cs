using PrimeiroProjeto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class TestEnvironment {
        static void Main(string[] args) {
            Product tv = new Product();

            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");  tv.nome = Console.ReadLine();
            Console.Write("Preço: "); tv.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: "); tv.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + tv);

            Console.Write("Digite o número de produtos a serem adicionados: ");
            tv.AdicionarProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + tv);

            Console.Write("Digite o número de produtos a serem removidos: ");
            tv.RemoverProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + tv);
        }
    }
}
