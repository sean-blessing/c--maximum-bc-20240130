using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab061AInheritance {
    internal class BusinessCheckingAccount : CheckingAccount {
        public string CompanyName { get; set; }
        public string FederalID { get; set; }

        public BusinessCheckingAccount(int accountID, string firstName, string lastName,
            string address, string city, string state, string zip, decimal balance,
            int lastCheckNumber, string companyName, string federalID) : base(accountID, firstName, lastName, address, city, state, zip, balance, lastCheckNumber) {
            CompanyName = companyName;
            FederalID = federalID;
        }

        public BusinessCheckingAccount(int accountID, string firstName, string lastName,
            string address, string city, string state, string zip,
            string companyName, string federalID) : base(accountID, firstName, lastName, address, city, state, zip) {
            CompanyName = companyName;
            FederalID = federalID;
        }
    }
}
