using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class RentStudent {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public RentStudent() { }

        public RentStudent(string name, string email, int quarto) {
            this.Name = name;
            this.Email = email;
            this.Quarto = quarto;
        }
    }
}
