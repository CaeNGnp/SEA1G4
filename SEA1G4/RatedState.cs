using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class RatedState : RideState {

        private RideContext context;

        public RatedState(RideContext c) {
            this.context = c;
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

        public void startRide() {
            throw new NotImplementedException();
        }
    }
}
