using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    class RideRequestedState : RideState
    {
        RideContext context;
        RideState state;

        public RideRequestedState(RideContext ctx) {
            context = ctx;
        }

        public void acceptBooking() {
            throw new NotImplementedException();
        }

        public void cancelBooking() {
            throw new NotImplementedException();
        }

        public void endRide() {
            throw new NotImplementedException();
        }

        public void entry() {
            throw new NotImplementedException();
        }

        public void exit() {
            throw new NotImplementedException();
        }

        public void giveRating(Rating r) {
            throw new NotImplementedException();
        }

        public void giveRating() {
            throw new NotImplementedException();
        }

        public void startRide() {
            throw new NotImplementedException();
        }
    }
}
