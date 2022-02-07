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
        private RideState state;

        public string PickupLoc { get; set; }
        public string DestinationLoc { get; set; }
        public Driver driver { get; set; }
        public Customer customer { get; set; }
        
    }
}
