using System;

namespace SEA1G4 {
    public class RideStartedState : RideState {
        private Ride ride;

        public RideStartedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            Console.WriteLine("Booking is accepted already");
        }

        public void cancelBooking() {
            Console.WriteLine("Booking is unable to be cancelled here");
        }

        public void startRide() {
            //Start ride in this state
            Console.WriteLine("Ride Start");
        }

        public void endRide() {
            Console.WriteLine("Unable to end ride as ride has not started");
        }

        public void giveRating(Rating rating) {
            Console.WriteLine("Unable to give rating as ride has not ended");
        }

        public void entry() {

        }

        public void exit() {

        }

        public void giveRating() {

        }

    }
}

