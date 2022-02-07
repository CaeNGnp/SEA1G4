using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public interface RideState {

        void acceptBooking();

        void cancelBooking();

        void startRide();

        void endRide();

        void giveRating(Rating r);

        void entry();

        void exit();
    }
}
