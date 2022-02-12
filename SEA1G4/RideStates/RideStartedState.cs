using System;

namespace SEA1G4 {
    public class RideStartedState : RideState {
        private Ride ride;

        public RideStartedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine("Booking is accepted already");
        }

        public void cancelBooking() {
            Console.WriteLine("Booking is unable to be cancelled as ride has already started");
        }

        public void startRide() {
            Console.Write("Ride already started.");
        }

        public void endRide() {
            // end ride
            ride.changeState(new RideDoneState(ride));
        }

        public void giveRating() {
            Console.WriteLine("Unable to give rating as ride has not ended");
        }

        public void makePayment() {
            Console.WriteLine("Unable to make payment as ride has not ended");
        }

        public void sendNotification() {
            Console.WriteLine("Ride has started");
        }
    }
}

