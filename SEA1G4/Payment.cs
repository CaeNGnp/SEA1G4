using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Payment {
        private Ride ride;

        public Payment(Ride r) {
            this.ride = r;
        }

        public void payFare() {
            double amt = ride.getFare();
            ride.getCustomer().payWithCreditCard(amt);
        }

        public void payBookingFee() {
            Vehicle v = ride.getDriver().getVehicle();
            if (v.getHasFee()) {
                Van van = (Van)v;
                double amt = van.getBookingFee();
                ride.getCustomer().payWithCreditCard(amt);
            }
        }

        public void creditToDriver() {
            double amt = ride.getFare();
            ride.getDriver().getBankAccount().creditAmount(amt);
        }
    }
}
