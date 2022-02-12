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
            Van van1 = new Van("sw3245f", "brand b", "van 2", false, true, true);
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
            CreditCard card = new CreditCard("2341123443211234", "John", 5000);
            Customer c = new Customer("John", "98765432", "john@email.com", "c1", card);

            // Populate one admin
            Admin adm = new Admin("Supreme Leader", "84272813", "supreme@kim.kp", "34faba12");

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
                    c.WriteLine("Available vehicles: ");

                    DefaultVehicleIterator iter = vehAgg.createIterator(true);

                    Vehicle chosen = null;
                    int i = 0;
                    while (iter.hasNext()) {
                        i++;

                        Vehicle vehi1 = iter.getNext();
                        c.WriteLine("[" + i + "]License Plate: " + vehi1.LicensePlate + " Brand: " + vehi1.Brand + " Model: " + vehi1.Model + " Driver: " + vehi1.Driver.Name);

                        c.Write("Choose this vehicle? [Y/N] ");

                        string inp = Console.ReadLine().Trim().ToLower();
                        if (inp == "n") {
                            continue;
                        }
                        chosen = vehi1;
                        break;
                    }

                    //checked null chosen
                    if (chosen is Van) {
                        Console.WriteLine("Deposit amount to be paid: $5");
                        Console.Write("Date of Ride (e.g. 12/2/2022):");
                        DateTime bookingDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Time of Ride (e.g. 12:00pm):");
                        DateTime bookingTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Date: " + bookingDate.ToString("dd/MM/yyyy") + " Time: " + bookingTime.ToString("HH:mm") + " Type any key to confirm.");
                        Console.ReadLine();
                        Van va = (Van)chosen;
                        c.payWithCreditCard(va.Deposit);
                        ride = new Ride("1234", pick, des, c, bookingDate.Date, bookingTime.ToString("HH:mm"));
                    } else if (chosen is ExcursionBus) {
                        Console.WriteLine("Deposit amount to be paid: 12");
                        Console.Write("Date of Ride (e.g. 12/2/2022):");
                        DateTime bookingDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Time of Ride:");
                        DateTime bookingTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Date: " + bookingDate.ToString("dd/MM/yyyy") + " Time: " + bookingTime.ToString("HH:mm") + " Type any key to confirm.");
                        Console.ReadLine();
                        ExcursionBus eb = (ExcursionBus)chosen;
                        c.payWithCreditCard(eb.Deposit);
                        ride = new Ride("1234", pick, des, c, bookingDate.Date, bookingTime.ToString("HH:mm"));
                    } else {
                        DateTime booking = DateTime.Now;
                        DateTime bookingDate = booking.Date;
                        string bookingTime = booking.ToString("HH:mm");
                        ride = new Ride("1234", pick, des, c, bookingDate.Date, bookingTime);
                    }

                    // no need to accept driver as already picked based on vehicle
                    ride.driver = chosen.Driver;

                    // Edit by Caelan - register admin to observe any rating updates
                    ride.registerRatingObserver(adm);

                    // 8. Use case continue at Accept Booking

                    // start ride (k2)
                    RideStartedState start = new RideStartedState(ride);
                    start.startRide();
                })
                
                

                .AddOption("Cancel booking", (m) => {
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }
                    else {
                        Console.WriteLine("Are you sure you want to cancel your Booking! [Y/N]");
                        string answer= Console.ReadLine().Trim().ToLower();
                        if (answer == "y") { 
                        
                        }
                    }
                    ride.promptCustomerAccept();

                })

               
                .AddOption("Make payment", (m) => {
                    // Make payment
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }

                    ride.makePayment();
                })
                .AddOption("Rate driver", (m) => {
                    Console.WriteLine("Ride ended.");
                    Console.Write("Rate driver [1-5]: ");
                    string rate = Console.ReadLine();
                    int rating = Convert.ToInt32(rate);
                    Rating r = new Rating(c, d1);
                    r.setRating(rating);
                    Console.Write("Any feedback to give? [Y/N]");
                    string res = Console.ReadLine().ToLower();
                    if(res == "y") {
                        Console.Write("Give feedback: ");
                        string feedback = Console.ReadLine();
                        r.setFeedback(feedback);
                    }
                    Console.Write("Ratings Done!");
                    ride.changeState(new RatedState(ride));

                    // Edit by Caelan - update observers about rating done
                    ride.notifyRatingObservers(r);
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
                .AddOption("End ride", (m) => {
                    if (ride == null) {
                        Console.WriteLine("No ride or assigned driver yet. Make a booking first");
                        return;
                    }
                    ride.endRide();
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
