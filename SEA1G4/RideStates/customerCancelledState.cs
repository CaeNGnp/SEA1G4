using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class customerCancelledState : RideState {

        private Ride ride;
      
      //  double amount;
        public customerCancelledState(Ride ride) {
            this.ride = ride;
        }
        public void acceptBooking() {
            ride.driver.WriteLine(
                "You may not accept the booking as the customer has cancelled it."
            );
        }
        public static DateTime Now { get; }

        public void cancelBooking() {
            Console.WriteLine("Ride Start");
            //while (true) {
            //    Console.WriteLine("Do you want to start ride? [Y/N] ");
            //    int TotalDays = (Now - ride.startDate).TotalDays;
            //    string ans = Console.ReadLine().Trim().ToLower();
            //    if (ans == "y") {
                                 
            //        if (TotalDays < 0) {
            //            if (ride.driver.MyVehicle == ExcursionBus) {
            //                amount = "0";
            //               ride.customer.cc.deposit(amount);
            //            }
            //        }

            //        else if (ride.startDate < Now) {
            //            if (ride.driver.MyVehicle == Van) { 
            //                amount = "0";
            //                ride.customer.cc.deposit(amount);
            //            }
            //        }

            //    } else if (ans == "n") {
            //        continue;
            //    }
            //}
        }
       
        public void endRide() {
            ride.driver.WriteLine(
                "You may not end the ride as the customer has cancelled it."
            );
        }

        public void giveRating() {
            ride.customer.WriteLine(
                "You may not rate the driver as you have cancelled the ride."
            );
        }

        public void makePayment() {
            ride.customer.WriteLine(
                "You may not pay for the ride as you have cancelled it."
            );
        }

        public void sendNotification() {
            Console.WriteLine("Ride is cancelled!");
        }

        public void startRide() {
            ride.driver.WriteLine(
                "You may not start the ride as the customer has cancelled it."
            );
        }
    }

}
