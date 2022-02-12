using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Driver : User {
        private BankAccount myBankAccount;
        private Vehicle myVehicle;
        private List<Ride> rideList;

        public Driver(string n, string c, string e, string id, BankAccount acc, Vehicle v) : base(n, c, e, id) {
            this.myBankAccount = acc;
            this.myVehicle = v;
            v.Driver = this;
            rideList = new List<Ride>();
        }

        public BankAccount MyBankAccount {
            set { myBankAccount = value; }
            get { return myBankAccount; }
        }

        public Vehicle MyVehicle {
            set { myVehicle = value; }
            get { return myVehicle; }
        }

        public void onRideRequested(Ride r) {
            WriteLine($"------Driver------");
            WriteLine($"You have a ride waiting to be accepted!");
            WriteLine($"Customer Name: {r.customer.Name}");
            WriteLine($"Contact No.: {r.customer.ContactNo}");
            WriteLine($"Email Address: {r.customer.EmailAddress}");
            WriteLine($"Date: {r.StartTime.ToString("dd/MM/yyyy")}");
            WriteLine($"Time: {r.StartTime.ToString("HH:mm")}");
            WriteLine($"Pick Up Location: {r.PickUpLoc}");
            WriteLine($"Destination Location: {r.DestinationLoc}");

        }
    }
}
