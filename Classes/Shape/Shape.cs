using PrimeiroProjeto.Classes.Shape.Enums;

namespace PrimeiroProjeto.Classes.Shape
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) { Color = color; }

        public abstract double Area();
    }
}
