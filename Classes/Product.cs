using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class Product {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Product(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Product(string nome, double preco) {
            _nome = nome;
            Preco = preco;
        }

        public Product() { }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
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
            return _nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque();
        }
    }
}
