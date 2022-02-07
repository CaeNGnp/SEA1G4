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
            double amt = ride.Fare;
            ride.customer.payWithCreditCard(amt);
        }

        public void payBookingFee() {
            Vehicle v = ride.driver.MyVehicle;
            if (v.getHasFee()) {
                Van van = (Van)v;
                double amt = van.BookingFee;
                ride.customer.payWithCreditCard(amt);
            }
        }

        public void creditToDriver() {
            double amt = ride.Fare;
            ride.driver.MyBankAccount.creditAmount(amt);
        }

        public void payFare(double fare) {
            ride.customer.payWithCreditCard(fare);
        }

        public void payBookingFee(double fee) {
            ride.customer.payWithCreditCard(fee);
        }

        public void creditToDriver(double fare) {
            ride.driver.MyBankAccount.creditAmount(fare);
        }
    }
}
