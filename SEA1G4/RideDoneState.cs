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
            Console.WriteLine("Cannot accept booking. Rating is still pending.");
        }

        public void cancelBooking() {
            Console.WriteLine("Cannot cancel booking. Rating is still pending.");
        }

        public void endRide() {
            Console.WriteLine("Ride has already ended.");
        }

        public void entry() {
            //// make payment for fare credit card
            //double fare = context.Ride.Fare;
            //context.Ride.Payment.payFare(fare);
            context.Ride.Payment.payFare();

            //// credit to driver
            //context.Ride.Payment.creditToDriver(fare);
            context.Ride.Payment.creditToDriver();

            //// check if have booking fee
            //Vehicle v = context.Ride.driver.MyVehicle;
            //if (v.getHasFee()) {
            //    // make payment for fee
            //    Van van = (Van)v;
            //    double fee = van.BookingFee;
            //    context.Ride.Payment.payBookingFee(fee);
            //}
            context.Ride.Payment.payBookingFee();
        }

        public void exit() {
            // send e-receipt
            context.Ride.sendReceipt();
            // add points
            context.Ride.customer.addPoints(context.Ride.Fare);
        }

        public void giveRating(Rating r) {
            // customer give rating
            context.Ride.Rating = r;

            // change state
            context.changeState(new RatedState(context));
        }

        public void startRide() {
            Console.WriteLine("Cannot start ride. Ride has already ended.");
        }
    }
}
