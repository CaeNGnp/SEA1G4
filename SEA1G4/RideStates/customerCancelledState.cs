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
         //   Console.WriteLine("Ride Cancelled");
          /*  while (true) {

                Console.WriteLine("Do you want to cancel ride? [Y/N] ");
                double TotalDays = (Now - ride.StartDate).TotalDays;
                string ans = Console.ReadLine().Trim().ToLower();
                if (ans == "y") {
                    Vehicle v = ride.driver.MyVehicle;

                    if (TotalDays > 3) {
                        if (v is ExcursionBus) {
                            ExcursionBus bus = (ExcursionBus)v;
                            ride.customer.addToCreditCard(bus.Deposit);
                            Console.WriteLine("Deposit refunded and your ride has been cancelled");

                        } else if (v is Van) {
                            Van va = (Van)v;
                            ride.customer.addToCreditCard(va.Deposit);
                            Console.WriteLine("Deposit refunded and your ride has been cancelled");

                        } else if (v is Car) {
                            Console.WriteLine("Ride cancelled!");
                        }

                    }
                }
            }*/
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

     
       


