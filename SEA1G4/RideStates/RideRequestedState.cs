using System;

namespace SEA1G4 {
    public class RideRequestedState : RideState {
        private Ride ride;

        public RideRequestedState(Ride ride) {
            this.ride = ride;
        }


        public void acceptBooking() {
            // UC-2: Accept booking

            Driver d = ride.driver;
            // 2.	System provides information about the booking
            // TODO customer name
            //d.WriteLine($"Pickup location: {context.Ride.PickupLoc}");


            while (true) {
                // 3.	System prompts admin whether to accept the booking.
                d.Write("Accept the booking? [Y/N]");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y") {
                    // 4. Driver replies with “Yes”. 
                    // 5. System transitions ride into DriverAssigned state                  
                    ride.changeState(new DriverAssignedState(ride));
                    break;
                } else if (response == "n") {
                    // 4.2.	Use case ends.
                    ride.changeState(new DriverCancelledState(ride));
                    return;
                }
            }

            // 5. System transitions ride into DriverAssigned state
            ride.changeState(new DriverAssignedState(ride));

            return;
        }

        public void cancelBooking() {
            throw new NotImplementedException();
        }

        public void endRide() {
            throw new NotImplementedException();
        }

        public void giveRating() {
            throw new NotImplementedException();
        }

        public void makePayment() {
            throw new NotImplementedException();
        }

        public void sendNotification() {
            ride.driver.update(ride);        
        }

        public void startRide() {
            throw new NotImplementedException();
        }
    }
}
