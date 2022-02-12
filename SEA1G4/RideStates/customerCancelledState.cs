using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class cancelBookingState : RideState {

        private Ride ride;
      
        string amount;
        public cancelBookingState(Ride ride) {
            this.ride = ride;
        }
        public void acceptBooking() {
            throw new NotImplementedException();
        }
        public static DateTime Now { get; }
       
        public void cancelBooking() {
            Console.WriteLine("Ride Cancel");
            while (true) {
                Console.WriteLine("Do you want to cancel ride? [Y/N] ");
                double TotalDays = (Now - ride.StartDate).TotalDays;
                string ans = Console.ReadLine().Trim().ToLower();
                if (ans == "y") {
                                 
                    if (TotalDays < 0) {
                        Vehicle v = ride.driver.MyVehicle;
                        ExcursionBus bus = (ExcursionBus)v;
                        if (ride.driver.MyVehicle == bus) {
                            amount = "0";
                         //  ride.customer.myCreditCard.deposit(amount);
                        }
                    }

                    else if (ride.StartDate < Now) {
                        Vehicle v = ride.driver.MyVehicle;
                        Van va = (Van)v;

                        if (ride.driver.MyVehicle == va) { 
                            amount = "0";
                           // ride.customer.myCreditCard.deposit(amount);
                        }
                    }

                } else if (ans == "n") {
                    continue;
                }
            }
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
            throw new NotImplementedException();
        }

        public void startRide() {
            throw new NotImplementedException();
        }
    }

}
