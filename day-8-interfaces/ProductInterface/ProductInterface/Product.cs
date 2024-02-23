using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInterface {
    internal abstract class Product : Printable {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string code, string description, decimal price) {
            Code = code;
            Description = description;
            Price = price;
        }

        public virtual string print() {
            return $"Product Info: {Code} - {Description}: ${Price}";
        }
    }
}
