using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class CreditCard {
        private string cardNumber;
        private string accountName;
        private double amount;

        public CreditCard(string no, string name, double amt) {
            cardNumber = no;
            accountName = name;
            amount = amt;
        }
    }
}
