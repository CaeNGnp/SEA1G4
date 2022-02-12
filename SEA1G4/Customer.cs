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

        public bool isPremium { get; set; }

        public Customer(string n, string c, string e, string id, CreditCard cc) : base(n, c, e, id) {
            observers = new List<CustomerObserver>();
            myCreditCard = cc;
            amountSpent = 0;
            points = 0;
            isPremium = false;
        }

        public void payWithCreditCard(double amt) {
            myCreditCard.deduct(amt);
            amountSpent += amt;
        }

        public void addPoints(double amount) {
            points += Convert.ToInt32(Math.Floor(amount));
            Console.WriteLine(Convert.ToInt32(Math.Floor(amount)) + " PickUpNow points added");
        }

        public void upgradePremium() {
            if (amountSpent >= 500 && isPremium == false) {
                new PremiumCustomer(Name, ContactNo, EmailAddress, UserId, myCreditCard);
                isPremium = true;
                Console.WriteLine(Name + " upgraded to Premium Customer.");
            } 
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

        public void driverAccepted() {
            notifyObservers();
        }
    }
}
