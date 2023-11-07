namespace PrimeiroProjeto.Classes.Order
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            Product = product;
        }

        public double SubTotal() { return Quantity * Price; }

        public override string ToString()
        {
            return Product.Name + ", $" + Price + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal();
        }
    }
}
