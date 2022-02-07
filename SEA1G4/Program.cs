using System;
using System.Collections.Generic;

namespace SEA1G4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello welcome to PickUpNow!");

            // Populate a drivers list
            List<Driver> drivers = new List<Driver>();

            // Populate one customer
            // TODO (DIY)

            // Populate one admin
            Admin adm = new Admin("Supreme Leader", "84272813", "supreme@kim.kp", "34faba12");

            // Make booking
            // TODO (DIY)
            Ride ride = new Ride();

            // Accept booking


            // Cancel booking(Customer)
            // TODO (DIY)

            // Start ride
            // TODO (DIY)
            /*while (true) {
               
                Console.WriteLine("Do you want to create a new follow up action? [Y/N] ");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y") {
                    break;
                } else if (response == "n") {
                    ;
                }
            }*/
            // Make payment
            // TODO (DIY)

            // Rate Customer
            // TODO (DIY)

            // Process feedback
            // TODO (DIY)


        }
    }
}
