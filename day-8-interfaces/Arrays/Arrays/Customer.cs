using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    internal class Customer {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public Customer(string name, string email, string phone) {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public override string? ToString() {
            return $"{Name}";
        }
    }
}
