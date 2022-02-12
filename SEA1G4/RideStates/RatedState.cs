using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class RatedState : RideState {

        private Ride ride;

        public RatedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine("Cannot accept booking. Rating done");
        }

        public void cancelBooking() {
            Console.WriteLine("Cannot cancel booking. Rating done");
        }

        public void endRide() {
            Console.WriteLine("Ride has ended. Rating done");
        }

        public void giveRating() {
            ride.customer.WriteLine(
                "You may not rate the driver as you have already done so."
            );
        }

        public void makePayment() {
            ride.customer.WriteLine(
                "You may not pay for the ride as it has already been paid for."
            );
        }

        public void sendNotification() {
            ride.customer.WriteLine("Thank you for your rating, we hope you enjoyed using PickUpNow!");
        }

        public void startRide() {
            ride.customer.WriteLine(
                "You may not pay for the ride as it has already ended."
            );
        }
    }
}
