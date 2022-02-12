using System;

namespace SEA1G4 {
    /// <summary>
    /// The DriverCancelled state exists only to handle the case where driver declines a booking.
    /// There is no use case description implemented for “Driver cancel booking” due to the scope
    /// of our implementation 
    /// </summary>
    public class DriverCancelledState : RideState {
        private Ride ride;

        public DriverCancelledState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine(
                "You may not accept the booking as you have already declined it."
            );
        }

        public void cancelBooking() {
            ride.customer.WriteLine(
                "You may not cancel the booking as your ride has been cancelled."
            );
        }

        public void endRide() {
            ride.driver.WriteLine(
                "You may not end the ride as it has been cancelled."
            );
        }

        public void giveRating() {
            ride.customer.WriteLine(
                "You may not rate the driver as the ride has been cancelled."
            );
        }

        public void makePayment() {
            ride.customer.WriteLine(
                "You may not pay for the ride as it has been cancelled."
            );
        }

        public void sendNotification() {
            Console.WriteLine("The ride has been cancelled. Make a new booking.");
        }

        public void startRide() {
            ride.driver.WriteLine(
                "You may not start the ride as it has been cancelled."
            );
        }
    }
}
