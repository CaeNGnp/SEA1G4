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

        public void entry() {
            throw new NotImplementedException();
        }

        public void exit() {
            throw new NotImplementedException();
        }

        public void startRide() {
            throw new NotImplementedException();
        }

        public void giveRating() {
            throw new NotImplementedException();
        }

        public void makePayment() {
            throw new NotImplementedException();
        }

        public void sendNotification() {
            throw new NotImplementedException();
        }
    }
}
