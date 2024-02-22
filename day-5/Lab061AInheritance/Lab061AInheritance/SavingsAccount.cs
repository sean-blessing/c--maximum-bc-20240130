using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab061AInheritance {
    internal class SavingsAccount : BankingAccount {
        public decimal InterestRate { get; set; }

        public SavingsAccount(int accountID, string firstName, string lastName, 
            string address, string city, string state, string zip) : base
            (accountID, firstName, lastName, address, city, state, zip) {

        }
    }
}
