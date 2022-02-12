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
        private Payment payment;
        private Rating rating;

        private RideState state;

        public Ride(string n, string pl, string dl) {
            referenceNo = n;
            pickupLoc = pl;
            destinationLoc = dl;
            fare = 21; // for testing purposes
            distance = 3; // for testing purposes
            payment = new Payment(this);

            // start
            state = new RideRequestedState(this);
        }
        
        public Driver driver { get; set; }
        public Customer customer { get; set; }

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

        public void makePayment() {
            state.makePayment();
        }

        public void giveRating() {
            state.giveRating();
        }

        public void promptCustomerAccept() {

            // todoo (DIY) input validat
            Console.Write("accept? [y/n]");

            string input = Console.ReadLine().Trim().ToLower();
            if (input == "y") {
                changeState(new RideStartedState(this));
            }

            // cancel booking(vandana)
            // TODO (DIY)
            Console.Write("You want to cancel booking? [y/n]");
            string answer = Console.ReadLine().Trim().ToLower();
            if (input == "y") {
                changeState(new cancelBookingState(this));
            }
        }

        /// <summary>
        /// Logs the current ride state and sends a notification if any.
        /// </summary>
        public void sendNotification() {
            // Log the current ride state
            Console.WriteLine("Current ride state: " + state);
            // Send notification if any
            state.sendNotification();
        }
    }
}
