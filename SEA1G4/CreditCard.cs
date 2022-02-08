using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class CreditCard {
        private string cardNumber;
        private string accountName;
        private double balance;

        public CreditCard(string no, string name, double bal) {
            cardNumber = no;
            accountName = name;
            balance = bal;
        }

        public void deduct(double a) {
            if (checkBalance(a)) {
                balance = balance - a;
                Console.WriteLine("$" + a + " deducted from credit card.");
            } else {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public bool checkBalance(double a) {
            bool sufficient = true;

            if (a > balance) {
                sufficient = false;
            }

            return sufficient;
        }
    }
}
