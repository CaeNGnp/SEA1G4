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
        }

        public BankAccount getBankAccount() {
            return myBankAccount;
        }

        public Vehicle getVehicle() {
            return myVehicle;
        }
    }
}
