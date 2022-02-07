using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class RideDoneState : RideState {

        private RideContext context;

        public RideDoneState(RideContext c) {
            this.context = c;
        }

        public void acceptBooking() {
            // implement
        }

        public void cancelBooking() {
            // implement
        }

        public void endRide() {
            // implement
        }

        public void entry() {
            // make payment for fare credit card
            double fare = context.ride.Fare;
            context.ride.Payment.payFare(fare);
            
            // credit to driver
            context.ride.Payment.creditToDriver(fare);
            
            // check if have booking fee
            Vehicle v = context.ride.driver.MyVehicle;
            if (v.getHasFee()) {
                // make payment for fee
                Van van = (Van)v;
                double fee = van.BookingFee;
                context.ride.Payment.payBookingFee(fee);
            }
        }

        public void exit() {
            // send e-receipt
            context.ride.sendReceipt();
            // add points
            context.ride.customer.addPoints();
        }

        public void giveRating(Rating r) {
            // implement
        }

        public void startRide() {
            // implement
        }
    }
}
