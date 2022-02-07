using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class BankAccount {
        private string accountName;
        private string bankName;
        private double balance;

        public BankAccount(string an, string bn, double b) {
            this.accountName = an;
            this.bankName = bn;
            this.balance = b;
        }

        public void creditAmount(double amt) {
            balance += amt;
        }
    }
}
