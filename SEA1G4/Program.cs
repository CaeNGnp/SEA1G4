using System;
using System.Collections.Generic;

namespace SEA1G4 {
    class Program {
        static void Main(string[] args) {

            // Populate a drivers list
            List<Driver> drivers = new List<Driver>();
            BankAccount ba1 = new BankAccount("Driver 1", "1234567812345678", "abc bank", 1200);
            Car c1 = new Car("sd1234e", "brand a", "car 1", false, false, true);
            Driver d1 = new Driver("Driver 1", "87654321", "driver@email.com", "d1", ba1, c1);
            drivers.Add(d1);
            BankAccount ba2 = new BankAccount("Driver 2", "3214567812345678", "abc bank", 2200);
            Van van1 = new Van("sw3245f", "brand b", "van 2", false, false, true);
            Driver d2 = new Driver("Driver 2", "87654321", "driver@email.com", "d2", ba2, van1);
            drivers.Add(d2);
            BankAccount ba3 = new BankAccount("Driver 3", "2314567812345678", "abc bank", 1900);
            ExcursionBus b1 = new ExcursionBus("sh5678d", "brand c", "bus 3", false, false, true);
            Driver d3 = new Driver("Driver 3", "87654321", "driver@email.com", "d3", ba3, b1);
            drivers.Add(d3);
            BankAccount ba4 = new BankAccount("Driver 4", "4321567812345678", "abc bank", 1900);
            ExcursionBus b2 = new ExcursionBus("sq0000d", "brand e", "bus 1", false, false, false);
            Driver d4 = new Driver("Driver 4", "87654321", "driver@email.com", "d4", ba4, b2);
            drivers.Add(d4);

            // Populate a vehicles list
            DefaultVehicleAggregate vehAgg = new DefaultVehicleAggregate();
            vehAgg.addVehicle(c1);
            vehAgg.addVehicle(van1);
            vehAgg.addVehicle(b1);
            vehAgg.addVehicle(b2);

            // Populate one customer
            // TODO (DIY)
            CreditCard card = new CreditCard("2341123443211234", "John", 5000);
            Customer c = new Customer("John", "98765432", "john@email.com", "c1", card);

            // Populate one admin
            Admin adm = new Admin("Supreme Leader", "84272813", "supreme@kim.kp", "34faba12");

            // dummy ride (to rmv)
            Ride ride1 = new Ride("r1", "pickup", "destination");
            ride1.customer = c;
            ride1.driver = d2;

            // The current ride
            Ride ride = null;

            ConsoleMenu menu = new ConsoleMenu()
                .BeforeInteraction((m) => {
                    Console.WriteLine("Hello welcome to PickUpNow!\n" + new string('=', 28));

                    // Send notification if any
                    if (ride != null) {
                        ride.sendNotification();
                    }
                })

                // Customer options
                .AddHeading("Customer")
                .AddOption("Make booking", (m) => {
                    Console.Write("Destination: ");
                    string des = Console.ReadLine();
                    Console.Write("Pickup Point: ");
                    string pick = Console.ReadLine();

                    //Console.WriteLine("Pick vehicle:");
                    //Console.WriteLine("[a] Car");
                    //Console.WriteLine("[b] Van");
                    //Console.WriteLine("[c] Excursion Bus");
                    //string veh = Console.ReadLine();

                    c.WriteLine("Available vehicles: ");

                    DefaultVehicleIterator iter = vehAgg.createIterator(true);

                    Vehicle chosen = null;
                    int i = 0;
                    while (iter.hasNext()) {
                        i++;

                        Vehicle vehi1 = iter.getNext();
                        c.WriteLine("[" + i + "]License Plate: " + vehi1.LicensePlate + " Brand: " + vehi1.Brand + " Model: " + vehi1.Model + "Driver: " + vehi1.Driver.Name);

                        c.Write("choose this vehicle? [Y/N] ");

                        string inp = Console.ReadLine().Trim().ToLower();
                        // TODO (DIY) input vali
                        if (inp == "n") {
                            continue;
                        }
                        chosen = vehi1;
                        break;

                        
                    }

                    // todo (DIY)
                    //checked null chosen
                    if (chosen is Van) {
                        Console.WriteLine("Deposit amount to be paid: $5");
                        Console.Write("Date and Time of booking:");
                        string datetime = Console.ReadLine();
                        Console.Write("Date and Time: " + datetime + " Type any key to confirm.");
                        Console.ReadLine();
                        Console.WriteLine("Deposit Deducted.");
                        Console.WriteLine("------Driver------");
                        Console.WriteLine("You have a new Customer!");
                        Console.WriteLine("Name: " + c.Name);
                        Console.WriteLine("Phone Number: " + c.ContactNo);
                        Console.WriteLine("Email Address: " + c.EmailAddress);
                        Console.WriteLine("Date and Time: " + datetime);
                    } else if (chosen is ExcursionBus) {
                        Console.WriteLine("Deposit amount to be paid: $12");
                        Console.Write("Date and Time of booking:");
                        string datetime = Console.ReadLine();
                        Console.Write("Date and Time: " + datetime + " Type any key to confirm.");
                        Console.ReadLine();
                        Console.WriteLine("Deposit Deducted.");
                        Console.WriteLine("------Driver------");
                        Console.WriteLine("You have a new Customer!");
                        Console.WriteLine("Name: " + c.Name);
                        Console.WriteLine("Phone Number: " + c.ContactNo);
                        Console.WriteLine("Email Address: " + c.EmailAddress);
                        Console.WriteLine("Date and Time: " + datetime);
                    } else {
                        Console.WriteLine("------Driver------");
                        Console.WriteLine("You have a new Customer!");
                        Console.WriteLine("Name: " + c.Name);
                        Console.WriteLine("Phone Number: " + c.ContactNo);
                        Console.WriteLine("Email Address: " + c.EmailAddress);
                    }

                    
                    // Populate Ride obj
                    ride = new Ride("1234", pick, des);

                    // after choose driver
                    Console.Write("Accept driver? [Y/N] ");

                    string response = Console.ReadLine().Trim().ToLower();
                    if (response == "y") {
                        ride.driver = chosen.Driver;
                        ride.changeState(new DriverAssignedState(ride));


                        // start ride (k2)
                        //while (true) {
                        //    Console.WriteLine("Do you want to start ride? [Y/N] ");

                        //    string ans = Console.ReadLine().Trim().ToLower();
                        //    if (ans == "y") {
                        //        if (ans == "y") {
                        //            RideStartedState start = new RideStartedState();
                        //            start.startRide();
                        //            break;
                        //        } else if (ans == "n") {
                        //            continue;
                        //        }
                        //    }
                        //}
                    } else if (response == "n") {
                        //what happen here TODO (DIY)
                    }
                })
                .AddOption("Accept/Cancel booking", (m) => {
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }

                    ride.promptCustomerAccept();

                })
                .AddOption("Make payment", (m) => {
                    // Make payment
                    // TODO (DIY)
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }

                    // TODO...
                    //ride.makePayment();

                    while (true) {
                        // for testing
                        ride1.changeState(new RideDoneState(ride1));

                        // calculating
                        Console.WriteLine("Calculating fare...");
                        double rideFare = ride1.Fare;
                        double rideFee = 0;
                        Console.WriteLine("Trip fare: $" + rideFare);
                        if (ride1.driver.MyVehicle.getHasFee()) {
                            Van vann = (Van)ride1.driver.MyVehicle;
                            rideFee = vann.BookingFee;
                            Console.WriteLine("Booking fee: $" + rideFee);
                        }
                        double rideTotal = rideFare + rideFee;
                        Console.WriteLine("Total: $" + rideTotal);
                        Console.WriteLine();

                        // payment method
                        Console.WriteLine("Select payment method: ");
                        Console.WriteLine("[1] Credit Card");
                        Console.WriteLine("[2] PickUpNow Points (not implemented)");
                        Console.WriteLine("[3] Gift Card (not implemented)");
                        Console.Write("Pay with: ");
                        string pm = Console.ReadLine();
                        Console.WriteLine();

                        if (pm == "1") { 
                            Console.WriteLine("Payment in process...");

                            // transaction
                            Console.WriteLine("----");
                            Console.WriteLine();
                            //exit
                            break;
                        }

                    }


                })
                .AddOption("Rate driver", (m) => {
                    Console.WriteLine("Ride ended.");
                    Console.Write("Rate driver [1-5]: ");
                    string rate = Console.ReadLine();
                    int rating = Convert.ToInt32(rate);
                    Rating r = new Rating(c, d1);
                    r.setRating(rating);
                    Console.Write("Give feedback: ");
                    string feedback = Console.ReadLine();
                    r.setFeedback(feedback);
                    Console.Write("Ratings Done!");
                    ride.changeState(new RatedState(ride));
                })

                // Drivers option
                .AddHeading("Driver")
                .AddOption("Accept booking", (m) => {
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }

                    ride.acceptBooking();
                })
                .AddOption("Start ride", (m) => {
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }
                    ride.startRide();
                })

                // Admins option
                .AddHeading("Admin")
                .AddOption("Process rating", (m) => {
                    // probably not needed since it's an observer
                })
                .AddHeading()
                .AddExitOption("Exit");

            menu.DisplayInteraction();

            Console.WriteLine("Until next time! Press any key to exit the program.");
            Console.ReadKey();
        }

    }
}
