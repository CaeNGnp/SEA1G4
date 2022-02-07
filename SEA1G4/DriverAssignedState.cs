using System;

namespace SEA1G4 {
    public class DriverAssignedState : RideState {
        protected RideContext context;

        public DriverAssignedState(RideContext context) {
            this.context = context;
        }

        public void acceptBooking() {
            Driver d = context.Ride.driver;
            // 2.	System provides information about the booking
            // TODO customer name
            d.WriteLine($"Pickup location: {context.Ride.PickupLoc}");

            
            while (true) {
                // 3.	System prompts admin whether to accept the booking.
                d.Write("Accept the booking? [Y/N]");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y") {
                    break;
                } else if (response == "n") {
                    // 4.2.	Use case ends. TODO: ?
                    context.changeState(null);
                    return;
                }
            }

            return;
        }

        public void cancelBooking() {
            // No-op
            return;
        }

        public void endRide() {
            // No-op
            return;
        }

        public void giveRating(Rating r) {
            // No-op
            return;
        }

        public void startRide() {
            // No-op
            return;
        }
    }
}
