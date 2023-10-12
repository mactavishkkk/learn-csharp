using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    internal class Product {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque() {
            return quantidade * preco;
        }

        public void AdicionarProduto(int x) {
            this.quantidade += x;
        }

        public void RemoverProduto(int x) {
            this.quantidade -= x;
        }

        public override string ToString() {
            return nome + ", R$" + preco.ToString("F2") + ", " + quantidade + " unidades, Total: $" + ValorTotalEmEstoque();
        }
    }
}
