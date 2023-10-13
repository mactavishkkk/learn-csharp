using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Product {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Product(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int x) {
            this.Quantidade += x;
        }

        public void RemoverProduto(int x) {
            this.Quantidade -= x;
        }

        public override string ToString() {
            return Nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque();
        }
    }
}
