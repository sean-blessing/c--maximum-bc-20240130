using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab061AInheritance {
    internal class CheckingAccount : BankingAccount {
        public int LastCheckNumber { get; set; } = 1000;

        public CheckingAccount(int accountID, string firstName, string lastName, 
            string address, string city, string state, string zip, decimal balance, int lastCheckNumber) : base
            (accountID, firstName, lastName, address, city, state, zip) {
            LastCheckNumber = lastCheckNumber;
        }

        public CheckingAccount(int accountID, string firstName, string lastName,
            string address, string city, string state, string zip) : base
            (accountID, firstName, lastName, address, city, state, zip) {
        }

    }
}
