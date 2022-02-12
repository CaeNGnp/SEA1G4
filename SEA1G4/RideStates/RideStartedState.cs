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
            Console.WriteLine("Unable to end ride as ride has not started");
            // TODO (DIY) exit

        }

        public void entry() {

        }

        public void exit() {

        }

        public void giveRating() {
            Console.WriteLine("Unable to give rating as ride has not ended");
        }

        public void makePayment() {
            throw new NotImplementedException();
        }

        public void sendNotification() {
            throw new NotImplementedException();
        }
    }
}

