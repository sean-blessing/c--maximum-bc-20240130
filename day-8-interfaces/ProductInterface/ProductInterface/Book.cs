using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInterface {
    internal class Book : Product, Printable {
        public string Author { get; set; }
        public Book(string code, string description, decimal price, string author) : base(code, description, price) {
            Author = author;
        }

        public override string print() {
            return base.print() + $"Book Info: Author - {Author}";
        }
    }
}
