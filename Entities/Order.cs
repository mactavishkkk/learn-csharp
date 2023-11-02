using PrimeiroProjeto.Entities.Enums;
using System;

namespace PrimeiroProjeto.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", Data/hora: " + Moment + ", Status: " + Status;
        }
    }
}
