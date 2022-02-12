using System;

namespace SEA1G4 {
    public class DriverAssignedState : RideState {
        private Ride ride;

        public DriverAssignedState(Ride ride) {
            this.ride = ride;
        }

        public void acceptBooking() {
            ride.driver.WriteLine(
                "You may not accept the booking as you have already accepted it."
            );
        }

        public void cancelBooking() {
           /* ride.customer.WriteLine(
                "You may not cancel the booking as your ride has not started."
            );*/

            while (true) {
                DateTime Now = DateTime.Now;

                Console.WriteLine("Do you want to cancel ride? [Y/N] in riderequestedstate ");
                double TotalDays = (Now - ride.StartDate).TotalDays;
                string option = Console.ReadLine().Trim().ToLower();
                if (option == "y") {

                    Console.WriteLine("Ride Booking details: ");
                    Console.WriteLine("Pick up Location: " + ride.PickUpLoc);
                    Console.WriteLine("Destination: " + ride.DestinationLoc);
                    Console.WriteLine("Ride Date: " + ride.StartDate);

                    Console.WriteLine("Vehicle Selected: " + ride.driver.MyVehicle.Model);
                    Console.WriteLine("Are you sure you would like to cancel this booking? [Y/N]");
                    string ans = Console.ReadLine().Trim().ToLower();
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
                     //   ride.changeState(new customerCancelledState(ride));
                        break;
                    } else if (ans == "n") {
                        return;

                    }
                } else if (option == "n") {
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
                "You may not rate the driver as the ride has not started."
            );
        }

        public void makePayment() {
            ride.customer.WriteLine(
                "You may not pay for the ride as the trip has not started."
            );
        }

        public void sendNotification() {
            ride.driver.WriteLine("Start the ride once you have picked up your passenger!");
        }

        public void startRide() {
            // Transition to ride start.
            ride.changeState(new RideStartedState(ride));
        }
    }
}
