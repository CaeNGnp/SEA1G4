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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void giveRating() {
            throw new NotImplementedException();
        }

        public void makePayment() {
            throw new NotImplementedException();
        }

        public void sendNotification() {
            Console.WriteLine("Ride is cancelled!");
        }

        public void startRide() {
            throw new NotImplementedException();
        }
}

}
