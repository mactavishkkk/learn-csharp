using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class Product {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Product(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Product(string nome, double preco) {
            _nome = nome;
            _preco = preco;
        }

        public Product() { }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Preco {
            get { return _preco; }
        }

        public double Quantidade {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque() {
            return _quantidade * _preco;
        }

        public void AdicionarProduto(int x) {
            this._quantidade += x;
        }

        public void RemoverProduto(int x) {
            this._quantidade -= x;
        }

        public override string ToString() {
            return _nome + ", R$" + _preco.ToString("F2") + ", " + _quantidade + " unidades, Total: $" + ValorTotalEmEstoque();
        }
    }
}
