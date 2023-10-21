using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class Rectangle {
        public double width;
        public double height;

        public double Area() {
            return width * height;
        }
        public double Perimeter() {
            return 2 * (width + height);
        }
        public double Diagonal() {
            return Math.Sqrt(
                Math.Pow(width, 2) + Math.Pow(height, 2)
                );
        }
    }
}
