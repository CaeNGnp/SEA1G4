using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Ride : RatingSubject {
        private DateTime endTime;
        private DateTime startTime;
        private double fare;
        private double distance; // in km
        private string referenceNo;
        private string pickupLoc;
        private string destinationLoc;
        private Payment payment;
        private List<RideObserver> observers;
        private List<RatingObserver> ratingObservers;


        private RideState state;

        public Ride(string n, string pl, string dl, Customer c, DateTime st) {
            startTime = st;
            customer = c;
            referenceNo = n;
            pickupLoc = pl;
            destinationLoc = dl;
            fare = 21; // for testing purposes
            distance = 3; // for testing purposes
            payment = new Payment(this);
            observers = new List<RideObserver>();
            ratingObservers = new List<RatingObserver>();

            // start
            state = new RideRequestedState(this);
        }

        public Driver driver { get; set; }
        public Customer customer { get; set; }

        public string PickUpLoc {
            set { pickupLoc = value; }
            get { return pickupLoc; }
        }
        public string DestinationLoc {
            set { destinationLoc = value; }
            get { return destinationLoc; }
        }

        public double Distance {
            set { distance = value; }
            get { return distance; }
        }

        public DateTime Endtime {
            set { endTime = value; }
            get { return endTime; }
        }

        public double Fare {
            set { fare = value; }
            get { return fare; }
        }

        public Payment Payment {
            set { payment = value; }
            get { return payment; }
        }

        public DateTime StartTime {
            set { startTime = value; }
            get { return startTime; }
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

        public void notifyRideObservers() {
            foreach (RideObserver co in observers) {
                co.onRideRequested(this);
            }
        }

        public void registerRideObserver(RideObserver co) {
            observers.Add(co);
        }

        public void removeRideObserver(RideObserver co) {
            observers.Remove(co);
        }
        public void sendNotification() {
            // Log the current ride state
            Console.WriteLine("Current ride state: " + state);
            // Send notification if any
            state.sendNotification();
        }

        public void registerRatingObserver(RatingObserver o) {
            ratingObservers.Add(o);
        }

        public void removeRatingObserver(RatingObserver o) {
            ratingObservers.Remove(o);
        }

        public void notifyRatingObservers(Rating rating) {
            foreach (RatingObserver o in ratingObservers) {
                o.onRatingUpdated(rating);
            }
        }

        /// <summary>
        /// Converts the ride information into a string value
        /// </summary>
        public override string ToString() {
            StringBuilder buf = new StringBuilder();

            buf.AppendLine($"Ref no.: {referenceNo}");
            buf.AppendLine($"Customer Name: {customer.Name}");
            buf.AppendLine($"Contact No.: {customer.ContactNo}");
            buf.AppendLine($"Email Address: {customer.EmailAddress}");
            buf.AppendLine($"Date: {StartTime.ToString("dd/MM/yyyy")}");
            buf.AppendLine($"Time: {StartTime.ToString("HH:mm")}");
            buf.AppendLine($"Pick Up Location: {PickUpLoc}");
            buf.AppendLine($"Destination Location: {DestinationLoc}");

            if (payment.hasPaid) {
                buf.AppendLine($"Has Paid: {payment.hasPaid}");
            }

            return buf.ToString();
        }
    }
}
