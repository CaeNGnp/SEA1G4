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
            Console.WriteLine("Ride ended.");
            Console.Write("Rate driver [1-5]: ");
            string rate = Console.ReadLine();
            int rating = Convert.ToInt32(rate);
            Rating r = new Rating(ride.customer, ride.driver);
            r.setRating(rating);
            while (true) {
                Console.Write("Any feedback to give? [Y/N]");
                string res = Console.ReadLine().ToLower();
                if (res == "y") {
                    Console.Write("Give feedback: ");
                    string feedback = Console.ReadLine();
                    r.setFeedback(feedback);
                    Console.Write("Ratings Done!");
                    ride.notifyRatingObservers(r);
                    ride.changeState(new RatedState(ride));
                    break;
                } else if (res == "n") {
                    Console.Write("Ratings Done!");
                    ride.notifyRatingObservers(r);
                    ride.changeState(new RatedState(ride));
                    break;
                } else {
                    Console.Write("Incorrect choice. Choose Y/N. Please re-enter");
                    continue;
                }
            }
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
                    Console.WriteLine("[2] PickUpNow Points");
                    Console.WriteLine("[3] Gift Card");
                    Console.Write("Pay with: ");
                    string pm = Console.ReadLine();
                    Console.WriteLine();
                    if (pm == "1") {
                        Console.WriteLine("Payment with credit card in process...");

                        // transaction
                        ride.Payment.payFareWithCreditCard(rideTotal);
                        ride.Payment.creditToDriver(rideFare);
                        ride.customer.upgradePremium();
                        ride.customer.addPoints(rideFare);
                        ride.sendReceipt();
                        ride.Payment.hasPaid = true;
                        Console.WriteLine("\nPayment complete.");
                        break;
                    } else if (pm == "2") {
                        Console.WriteLine("Payment with points in process...");
                        // transaction
                        bool paid = ride.Payment.payFareWithPoints(rideTotal);
                        if (paid) {
                            ride.Payment.creditToDriver(rideFare);
                            ride.customer.upgradePremium();
                            ride.sendReceipt();
                            ride.Payment.hasPaid = true;
                            Console.WriteLine("\nPayment complete.");
                            break;
                        } else {
                            Console.WriteLine("Insufficient points. Please select another payment method.\n");
                            continue;
                        }
                    } else if (pm == "3") {
                        Console.WriteLine("Payment with points in process...");
                        // transaction
                        bool paid = ride.Payment.payFareWithGiftCard(rideTotal);
                        if (paid) {
                            ride.Payment.creditToDriver(rideFare);
                            ride.customer.upgradePremium();
                            ride.sendReceipt();
                            ride.Payment.hasPaid = true;
                            Console.WriteLine("\nPayment complete.");
                            break;
                        } else {
                            Console.WriteLine("Insufficient gift cards. Please select another payment method.\n");
                            continue;
                        }
                    } else {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }
                }
            } else {
                Console.WriteLine("Payment has already been made for this ride.");
            }       
        }

        public void sendNotification() {
            //ride.driver.WriteLine("Ride ended.");
            ride.customer.WriteLine("Destination reached. You may make your payment and give your driver a rating.");
        }

        public void startRide() {
            ride.driver.WriteLine("Cannot start ride. Ride has already ended.");
        }
    }
}
