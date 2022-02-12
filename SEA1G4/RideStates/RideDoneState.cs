using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class RideDoneState : RideState {

        private Ride ride;

        public RideDoneState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine("Cannot accept booking. Rating is still pending.");
        }

        public void cancelBooking() {
            Console.WriteLine("Cannot cancel booking. Rating is still pending.");
        }

        public void endRide() {
            Console.WriteLine("Ride has already ended.");
        }

        public void entry() {
            // make payment for fare credit card
            double fare = ride.Fare;
            ride.Payment.payFare(fare);
            //context.Ride.Payment.payFare();

            // credit to driver
            ride.Payment.creditToDriver(fare);
            //context.Ride.Payment.creditToDriver();

            // check if have booking fee
            Vehicle v = ride.driver.MyVehicle;
            if (v.getHasFee() == true) {
                // make payment for fee
                Van van = (Van)v;
                double fee = van.BookingFee;
                ride.Payment.payBookingFee(fee);
            }
            //context.Ride.Payment.payBookingFee();
        }

        public void exit() {
            // send e-receipt
            ride.sendReceipt();
            // add points
            ride.customer.addPoints(ride.Fare);
        }

        public void giveRating() {
            // customer give rating
            //ride.Rating = r;

            // change state
            ride.changeState(new RatedState(ride));
        }

        public void makePayment() {
            throw new NotImplementedException();
        }

        public void sendNotification() {
            throw new NotImplementedException();
        }

        public void startRide() {
            Console.WriteLine("Cannot start ride. Ride has already ended.");
        }
    }
}
