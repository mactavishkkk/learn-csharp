using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class Product {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double Price, int Quantity) {
            _name = name;
            Price = Price;
            Quantity = Quantity;
        }

        public Product(string name, double Price) {
            _name = name;
            Price = Price;
        }

        public Product() { }

        public string name {
            get { return _name; }
            set { _name = value; }
        }

        public double TotalValueStock() {
            return Quantity * Price;
        }

        public void AddProduct(int x) {
            this.Quantity += x;
        }

        public void RemoveProduct(int x) {
            this.Quantity -= x;
        }

        public override string ToString() {
            return _name + ", R$" + Price.ToString("F2") + ", " + Quantity + " unidades, Total: $" + TotalValueStock();
        }
    }
}
