using PrimeiroProjeto.Classes.Order;
using PrimeiroProjeto.Classes.Order.Enums;
using System;

namespace PrimeiroProjeto
{
    internal class Enums
    {
        static void Main(string[] args)
        {
            Order order = new Order { 
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // cw(txt); -> PendingPayment(0)
            OrderStatus status = Enum.Parse<OrderStatus>("Delivered"); // cw(status); -> Delivered(3)
        }
    }
}
