﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4 {
    public class Customer : User {
        private List<GiftCard> giftCardList;
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
            giftCardList = new List<GiftCard>();
            GiftCard gc = new GiftCard(10, "GC001", 8);
            giftCardList.Add(gc);
        }

        public List<GiftCard> GList {
            set { giftCardList = value; }
            get { return giftCardList; }
        }

        public void payWithCreditCard(double amt) {
            myCreditCard.deduct(amt);
        }

        public void payFareWithCreditCard(double amt) {
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
                payFareWithCreditCard(amount);
                addPoints(amount);
            } else if (points > 0 && points <= amt / 2) { // exisitng points
                double amount = amt - points;
                deductPoints(points);
                payFareWithCreditCard(amount);
                addPoints(amount);
            } else if (points == 0) {
                // insufficient points
                success = false;
            }
            return success;
        }

        public bool payWithGiftCard(double amt) {
            bool success = true;
            if (giftCardList.Count != 0) { // have gift cards
                Console.WriteLine("Your gift cards: ");
                int x = 1;
                foreach (GiftCard g in giftCardList) {
                    Console.WriteLine("[" + x + "] ID: " + g.cardId + "   Value: $" + g.value);
                    x++;
                }
                while (true) {
                    Console.Write("Select gift card: ");
                    int card = Convert.ToInt32(Console.ReadLine());
                    if (card <= giftCardList.Count) {
                        GiftCard gc = giftCardList[card - 1];
                        double amount = amt - gc.value;
                        giftCardList.RemoveAt(card - 1);
                        Console.WriteLine("Gift card " + gc.cardId + " with value $" + gc.value + " redeemed.");
                        if (gc.value <= amt) {
                            payFareWithCreditCard(amount);
                            addPoints(amount);
                            break;
                        } else {
                            addPoints(amt);
                            break;
                        }
                    } else {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }
                }
            } else { // no gift cards
                success = false;
            }
            return success;
        }

    }
}
