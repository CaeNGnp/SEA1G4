using System;

namespace SEA1G4 {
    public class DriverAssignedState : RideState {
        private Ride ride;

        public DriverAssignedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine("Cannot accept booking as you have already done so.");
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
            //throw new NotImplementedException();
        }

        public void startRide() {
            // TRansition to ride start.
            ride.changeState(new RideStartedState(ride));
            return;
        }
    }
}
