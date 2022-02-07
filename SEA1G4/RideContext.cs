using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    class RideContext {
        private Ride ride;

        public Ride Ride { get; private set; }

        public RideContext(Ride ride) {
            Ride = ride;
        }

        public void changeState(RideState state) {
            this.state = state;
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
            state.giveRating();
        }

        public void entry() {

        }

        public void exit() {

        }
    }
}
