using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Ride {
        private DateTime endTime;
        private DateTime startTime;
        private double fare;
        private double distance;
        private string referenceNo;
        private string pickupLoc;
        private string destinationLoc;
        private RideState state;
      

        public Driver driver { get; set; }
        public Customer customer { get; set; }
        
    }
}
