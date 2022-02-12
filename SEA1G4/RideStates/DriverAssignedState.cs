using System;

namespace SEA1G4 {
    public class DriverAssignedState : RideState {
        private Ride ride;

        public DriverAssignedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            Driver d = ride.driver;
            // 2.	System provides information about the booking
            // TODO customer name
            //d.WriteLine($"Pickup location: {context.Ride.PickupLoc}");

            
            while (true) {
                // 3.	System prompts admin whether to accept the booking.
                d.Write("Accept the booking? [Y/N]");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y") {
                    break;
                } else if (response == "n") {
                    // 4.2.	Use case ends. TODO: ?
                    ride.changeState(null);
                    return;
                }
            }
            
            // Use case continue to customer cancel

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

        public void entry() {
            throw new NotImplementedException();
        }

        public void exit() {
            throw new NotImplementedException();
        }

        public void giveRating() {
            // No-op
            return;
        }

        public void makePayment() {
            throw new NotImplementedException();
        }

        public void sendNotification() {
            throw new NotImplementedException();
        }

        public void startRide() {
            // TRansition to ride start.
            ride.changeState(new RideStartedState(ride));
            return;
        }
    }
}
