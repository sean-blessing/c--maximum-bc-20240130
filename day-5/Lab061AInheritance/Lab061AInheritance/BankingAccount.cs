using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab061AInheritance {
    public abstract class BankingAccount {

        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        private decimal _balance;
        public decimal Balance { get { return _balance; } }
        public DateTime DateOpened { get; set; }
        public string Status { get; set; }

        public BankingAccount(int accountID, string firstName, string lastName, 
            string address, string city, string state, string zip) {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            
            DateOpened = DateTime.Now;
            Status = "Pending";
        }

        public override string ToString() {
            return $"Account: {AccountID}, Owner: {LastName}, Balance: {Balance}, Status {Status}";
        }

        public decimal MakeDeposit(decimal amt) {
            _balance += amt;
            return _balance; // new balance
        }
        public decimal MakeWithdrawal(decimal amt) {
            if (amt <= _balance) {
                _balance -= amt;
                return _balance; // remaining balance
            }
            else { throw new Exception("Insufficient funds"); }
        }
    }
}
