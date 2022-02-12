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
            points = 0;
            PremiumPrivilege = pp;
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
            if (amountSpent >= 500 && PremiumPrivilege == null) {
                PremiumPrivilege = new PremiumCustomerPrivilege(this);
                Console.WriteLine(Name + " upgraded to Premium Customer.");
            } 
        }



    }
}
