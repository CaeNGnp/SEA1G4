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
            if (!ride.Payment.hasPaid) {
                // display fare
                Console.WriteLine("Calculating fare...");
                double rideFare = ride.Fare;
                double rideFee = 0;
                Console.WriteLine("Fee Type      | Amount ($)");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Trip fare          " + rideFare);
                if (ride.driver.MyVehicle.HasFee) {
                    Van van = (Van)ride.driver.MyVehicle;
                    rideFee = van.BookingFee;
                    Console.WriteLine("Booking fee        " + rideFee);
                }
                Console.WriteLine("---------------------------");
                double rideTotal = rideFare + rideFee;
                Console.WriteLine("TOTAL              " + rideTotal + "\n");

                while (true) {
                    // choose payment method
                    Console.WriteLine("Select payment method: ");
                    Console.WriteLine("[1] Credit Card");
                    Console.WriteLine("[2] PickUpNow Points (not implemented)");
                    Console.WriteLine("[3] Gift Card (not implemented)");
                    Console.Write("Pay with: ");
                    string pm = Console.ReadLine();
                    Console.WriteLine();
                    if (pm == "1") {
                        Console.WriteLine("Payment in process...");

                        // transaction
                        ride.Payment.payFareWithCreditCard(rideTotal);
                        ride.Payment.creditToDriver(rideFare);
                        ride.customer.upgradePremium();
                        ride.customer.addPoints(rideFare);
                        ride.sendReceipt();
                        Console.WriteLine("\nPayment complete.");
                        break;
                    } else if (pm == "2") {
                        Console.WriteLine("Payment in process...");
                        // transaction

                    } else {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }
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
