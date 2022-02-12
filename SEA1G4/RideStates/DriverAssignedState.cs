using System;

namespace SEA1G4 {
    public class DriverAssignedState : RideState {
        private Ride ride;

        public DriverAssignedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine(
                "You may not accept the booking as you have already accepted it."
            );
        }

        public void cancelBooking() {
            ride.customer.WriteLine(
                "You may not cancel the booking as your ride has not started."
            );
        }

        public void endRide() {
            ride.driver.WriteLine(
                "You may not end the ride as it has not started."
            );
        }

        public void giveRating() {
            ride.customer.WriteLine(
                "You may not rate the driver as the ride has not started."
            );
        }

        public void makePayment() {
            ride.customer.WriteLine(
                "You may not pay for the ride as the trip has not started."
            );
        }

        public void sendNotification() {
            ride.driver.WriteLine("Start the ride once you have picked up your passenger!");
        }

        public void startRide() {
            // TRansition to ride start.
            ride.changeState(new RideStartedState(ride));
        }
    }
}
