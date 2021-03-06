using System;

namespace SEA1G4 {
    public class RideRequestedState : RideState {
        private Ride ride;

        public RideRequestedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            // UC-2: Accept booking

            Driver d = ride.driver;
            // 2.	System provides information about the booking
            d.WriteLine("Booking information:");
            d.WriteLine("\n" + new string('=', 16) + "\n" + ride.ToString() + new string('=', 16));

            while (true) {
                // 3.	System prompts admin whether to accept the booking.
                d.Write("Accept the booking? [Y/N] ");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y") {
                    // 4. Driver replies with “Yes”.
                    break;
                } else if (response == "n") {
                    // 4.2.	Use case ends.
                    ride.changeState(new DriverCancelledState(ride));
                    return;
                }
            }

            // 5. System transitions ride into DriverAssigned state
            ride.changeState(new DriverAssignedState(ride));

            return;
        }

        public void cancelBooking() {
            while (true) {
                DateTime Now=DateTime.Now;

                Console.WriteLine("Do you want to cancel ride? [Y/N] in riderequestedstate ");
                double TotalDays = (Now - ride.StartTime).TotalDays;
                string option = Console.ReadLine().Trim().ToLower();
                if (option == "y") {

                    Console.WriteLine("Ride Booking details: ");
                    Console.WriteLine("Pick up Location: " + ride.PickUpLoc);
                    Console.WriteLine("Destination: " + ride.DestinationLoc);
                    Console.WriteLine("Ride Date: " + ride.StartTime);

                    Console.WriteLine("Vehicle Selected: " + ride.driver.MyVehicle.Model);
                    Console.WriteLine("Are you sure you would like to cancel this booking? [Y/N]");
                    string ans= Console.ReadLine().Trim().ToLower();
                    if (ans == "y") {
                        Vehicle v = ride.driver.MyVehicle;

                        if (TotalDays > 3) {
                            if (v is ExcursionBus) {
                                ExcursionBus bus = (ExcursionBus)v;
                                ride.customer.addToCreditCard(bus.Deposit);
                                Console.WriteLine("Deposit refunded!");

                            } else if (v is Van) {
                                Van va = (Van)v;
                                ride.customer.addToCreditCard(va.Deposit);
                                Console.WriteLine("Deposit refunded!");

                            }
                        }
                        Console.WriteLine("Ride cancelled");
                        ride.changeState(new customerCancelledState(ride));
                        break;
                    } else if (ans == "n") {
                        return;

                    }
                }
                else if(option=="n") {
                    return;
                }

            }
        }

        public void endRide() {
            ride.driver.WriteLine(
                "You may not end the ride as it has not started."
            );
        }

        public void giveRating() {
            ride.customer.WriteLine(
                "You may not rate the driver as the ride has not been completed."
            );
        }

        public void makePayment() {
            ride.customer.WriteLine(
                "You may not pay for the ride as it has not been completed."
            );
        }

        public void sendNotification() {
            ride.driver.onRideRequested(ride);
        }

        public void startRide() {
            ride.driver.WriteLine(
                "You may not start the ride as it has not been accepted yet."
            );
        }
    }
}
