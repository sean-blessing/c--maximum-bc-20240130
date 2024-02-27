using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass {
    internal partial class BankAccount {
        public int AcctID { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }

        // needs SQL classes such as GetDataFromSQL

        // need financial functions
    }
}
