using PrimeiroProjeto.Classes.Order.Enums;
using System.Text;

namespace PrimeiroProjeto.Classes.Order
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item) { Items.Add(item); }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            double subtotal = 0;
            foreach (OrderItem item in Items)
            {
                subtotal = item.SubTotal();
                total += subtotal;
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine("ORDER SUMMARY");
            SB.Append("Order moment: ");
            SB.AppendLine(Moment.ToString("G"));
            SB.AppendLine("Order status: " + Status);
            SB.Append("Client: " + Client.Name);
            SB.Append(" " + Client.BirthDate.ToString("G") + " - ");
            SB.AppendLine(Client.Email);
            SB.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                SB.AppendLine(item.ToString());
            }
            SB.AppendLine("Total price: $" + Total());
            return SB.ToString();
        }
    }
}
