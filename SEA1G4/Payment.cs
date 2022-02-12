using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Payment {
        private Ride ride;
        public bool hasPaid { get; set; }

        public Payment(Ride r) {
            this.ride = r;
            hasPaid = false;
        }

        public void payFareWithCreditCard(double fare) {
            ride.customer.payWithCreditCard(fare);
        }

        public bool payFareWithPoints(double fare) {
            return ride.customer.payWithPoints(fare);
        }

        public void creditToDriver(double fare) {
            ride.driver.MyBankAccount.creditAmount(fare);
        }
    }
}
