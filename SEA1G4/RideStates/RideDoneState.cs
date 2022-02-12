using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class RideDoneState : RideState {

        private Ride ride;

        public RideDoneState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine("Cannot accept booking. Rating is still pending.");
        }

        public void cancelBooking() {
            Console.WriteLine("Cannot cancel booking. Rating is still pending.");
        }

        public void endRide() {
            Console.WriteLine("Ride has already ended.");
        }

        public void giveRating() {
            // customer give rating
            //ride.Rating = r;

            // change state
            ride.changeState(new RatedState(ride));
        }

        public void makePayment() {
            // display fare
            Console.WriteLine("Calculating fare...");
            double rideFare = ride.Fare;
            double rideFee = 0;
            Console.WriteLine("Fee Type      | Amount ($)");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Trip fare          " + rideFare);
            if (ride.driver.MyVehicle.getHasFee()) {
                Van vann = (Van)ride.driver.MyVehicle;
                rideFee = vann.BookingFee;
                Console.WriteLine("Booking fee        " + rideFee);
            }
            Console.WriteLine("---------------------------");
            double rideTotal = rideFare + rideFee;
            Console.WriteLine("TOTAL              " + rideTotal + "\n");

            // choose payment method
            Console.WriteLine("Select payment method: ");
            Console.WriteLine("[1] Credit Card");
            Console.WriteLine("[2] PickUpNow Points (not implemented)");
            Console.WriteLine("[3] Gift Card (not implemented)");
            Console.WriteLine("[0] Cancel Payment");
            Console.Write("Pay with: ");
            string pm = Console.ReadLine();
            Console.WriteLine();
            while (pm != "0") {
                if (pm == "1") {
                    Console.WriteLine("Payment in process...");

                    // transaction
                    ride.Payment.payFare(rideTotal);
                    ride.Payment.creditToDriver(rideFare);
                    ride.customer.upgradePremium();
                    ride.customer.addPoints(rideFare);
                    ride.sendReceipt();
                    Console.WriteLine("\nPayment complete.\n");
                    break;
                } else {
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
                }

            }
        
        }

        public void sendNotification() {
            //ride.driver.WriteLine("Ride ended.");
            ride.customer.WriteLine("Destination reached. You may make your payment and give your driver a rating.");
        }

        public void startRide() {
            Console.WriteLine("Cannot start ride. Ride has already ended.");
        }
    }
}
