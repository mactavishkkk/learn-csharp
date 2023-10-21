using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Classes {
    class RentStudent {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public RentStudent() { }

        public RentStudent(string Name, string email, int room) {
            this.Name = Name;
            this.Email = email;
            this.Room = room;
        }
    }
}
