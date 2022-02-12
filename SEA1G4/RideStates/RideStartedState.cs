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
            //Start ride in this state
            // TODO (DIY)
            Console.WriteLine("Ride Start");
            while (true) {
                Console.WriteLine("Do you want to start ride? [Y/N] ");

                string ans = Console.ReadLine().Trim().ToLower();
                if (ans == "y") {

                } else if (ans == "n") {
                    continue;
                }
            }
        }

        public void endRide() {
            // TODO (DIY) exit
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

