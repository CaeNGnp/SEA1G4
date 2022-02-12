using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Customer : User, RideObserver {
        //private List<RideObserver> observers;
        public double amountSpent;
        public double points;
        private CreditCard myCreditCard;

        public Customer(string n, string c, string e, string id, CreditCard cc) : base(n, c, e, id) {
            myCreditCard = cc;
            //observers = new List<RideObserver>();
        }

        public void payWithPoints() {
            // to be implemented
        }

        public void payWithCreditCard(double amt) {
            myCreditCard.deduct(amt);
            amountSpent += amt;
        }

        public void addPoints(double amount) {
            points += Convert.ToInt32(Math.Floor(amount));
            Console.WriteLine(Convert.ToInt32(Math.Floor(amount)) + " PickUpNow points added");
        }

        public void update(Ride r) {
            // System notifies customer about driver accepted
            WriteLine($"Driver Name: {r.driver.Name}");
            WriteLine($"Contact No.: {r.driver.ContactNo}");
            WriteLine($"Email Address: {r.driver.EmailAddress}");
            //Console.WriteLine("test");
        }
        

       
    }
}
