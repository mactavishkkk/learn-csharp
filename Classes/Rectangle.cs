using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public double Diagonal()
        {
            return Math.Sqrt(
                Math.Pow(Width, 2) + Math.Pow(Height, 2)
                );
        }
    }
}
