using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInterface {
    internal class Software : Product, Printable{
        public string Version { get; set; }
        public Software(string code, string description, decimal price, string version) : base(code, description, price) {
            Version = version;
        }

        public override string print() {
            return base.print() + $"Software Info: Version - {Version}";
        }
    }
}
