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
        private double distance; // in km
        private string referenceNo;
        private string pickupLoc;
        private string destinationLoc;
        private RideContext context;
        private Payment payment;
        private Rating rating;

        public Ride(string n, string pl, string dl) {
            referenceNo = n;
            pickupLoc = pl;
            destinationLoc = dl;
            fare = 21; // for testing purposes
            distance = 3; // for testing purposes
            context = new RideContext(this);
            payment = new Payment(this);
        }
        
        public Driver driver { get; set; }
        public Customer customer { get; set; }

        public RideContext rideCtx {
            // readonly
            //set { context = value; }
            get { return context; }
        }

        public double Distance {
            set { distance = value; } 
            get { return distance; }
        }

        public DateTime Endtime {
            set { endTime = value; }
            get { return endTime; }
        }

        public Rating Rating {
            set { rating = value; }
            get { return rating; }
        }
        
        public double Fare {
            set { fare = value; } 
            get { return fare; }
        }

        public Payment Payment {
            set { payment = value; }
            get { return payment; }
        }

        public void sendReceipt() {
            Console.WriteLine("E-receipt sent!");
        }


    }
}
