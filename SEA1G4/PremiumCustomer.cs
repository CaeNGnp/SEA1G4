using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class PremiumCustomer : Customer {
        private GiftCard[] giftCardList;

        // edit after customer class is added
        public PremiumCustomer(string n, string c, string e, string id, CreditCard cc) : base(n, c, e, id, cc) { }

        public void purchaseGiftCard() {

        }
        public void payWithGiftCard(double amount) {

        }
    }
}
