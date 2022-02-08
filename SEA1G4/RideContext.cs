using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class RideContext {
        private Ride ride;
        private RideState state;

        public Ride Ride { get; private set; }

        public RideContext(Ride ride) {
            this.ride = ride;
            Ride = ride;
            state = new RideRequestedState(this);
        }

        public void changeState(RideState state) {
            this.state = state;
            Console.WriteLine("state changed: " + state);
        }

        public void acceptBooking() {
            state.acceptBooking();
        }

        public void cancelBooking() {
            state.cancelBooking();
        }

        public void startRide() {
            state.startRide();
        }

        public void endRide() {
            state.endRide();
        }

        public void giveRating(Rating rating) {
            state.giveRating(rating);
        }

        public void entry() {
            state.entry();
        }

        public void exit() {
            state.exit();
        }
    }
}
