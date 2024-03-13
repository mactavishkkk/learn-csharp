namespace PrimeiroProjeto.Classes.Product
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Price: " + Price + " | " + Category.Name + " - " + Category.Tier;
        }
    }
}
