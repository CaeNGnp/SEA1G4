using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Customer : User, CustomerSubject {
        private List<CustomerObserver> observers;
        public double amountSpent;
        public double points;
        private CreditCard myCreditCard;

        public Customer(string n, string c, string e, string id, CreditCard cc) : base(n, c, e, id) {
            myCreditCard = cc;
        }

        public void payWithPoints() {
            // to be implemented
        }

        public void payWithCreditCard(double amt) {
            myCreditCard.deduct(amt);
            amountSpent += amt;
            Console.WriteLine("$" + amt + " deducted from credit card.");
        }

        public void addPoints(double amount) {
            points += Convert.ToInt32(Math.Floor(amount));
            Console.WriteLine(Convert.ToInt32(Math.Floor(amount)) + " PickUpNow points added");
        }

        public void notifyObservers() {
            foreach (CustomerObserver co in observers)
            {
                co.update(this);
            }
        }

        public void registerObserver(CustomerObserver co) {
            observers.Add(co);
        }

        public void removeObserver(CustomerObserver co) {
            observers.Remove(co);
        }
    }
}
