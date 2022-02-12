using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Customer : User {
        public double amountSpent;
        public double points;
        private CreditCard myCreditCard;
        
        /// <summary>
        /// The customer's premium privellege. Null if not premium.
        /// </summary>
        public PremiumCustomerPrivilege PremiumPrivilege { get; private set; }

        public Customer(string n, string c, string e, string id, CreditCard cc, PremiumCustomerPrivilege pp = null) : base(n, c, e, id) {
            //observers = new List<RideObserver>();
            myCreditCard = cc;
            amountSpent = 0;
            points = 5;
            PremiumPrivilege = pp;
        }

        public void payWithCreditCard(double amt) {
            myCreditCard.deduct(amt);
            amountSpent += amt;
        }

        public void addToCreditCard(double amt) {
            myCreditCard.deposit(amt);
        }

        public void addPoints(double amount) {
            points += amount;
            Console.WriteLine(amount + " PickUpNow points added.");
        }

        public void deductPoints(double amount) {
            points -= amount;
            Console.WriteLine(amount + " PickUpNow points deducted.");
        }

        public void upgradePremium() {
            if (amountSpent >= 500 && PremiumPrivilege == null) {
                PremiumPrivilege = new PremiumCustomerPrivilege(this);
                Console.WriteLine(Name + " upgraded to Premium Customer.");
            } 
        }

        public bool payWithPoints(double amt) {
            bool success = true;
            if (points >= amt && PremiumPrivilege != null) { // premium customer
                deductPoints(amt);
            } else if (points > 0 && points >= amt / 2) { // sufficient points to pay half by points
                double amount = amt / 2;
                deductPoints(amount);
                payWithCreditCard(amount);
                addPoints(amount);
            } else if (points > 0 && points <= amt / 2) { // exisitng points
                double amount = amt - points;
                deductPoints(points);
                payWithCreditCard(amount);
                addPoints(amount);
            } else if (points == 0) {
                // insufficient points
                success = false;
            }
            return success;
        }

    }
}
