using System;
using System.Collections.Generic;

namespace SEA1G4 {
    class Program {
        static void Main(string[] args) {
            string option = "10";


            // Populate a drivers list
            List<Driver> drivers = new List<Driver>();
            BankAccount ba1 = new BankAccount("1234567812345678", "abc bank", 1200);
            Car c1 = new Car("sd1234e", "brand a", "car 1", false, false, true);
            Driver d1 = new Driver("Driver 1", "87654321", "driver@email.com", "d1", ba1, c1);
            drivers.Add(d1);
            BankAccount ba2 = new BankAccount("3214567812345678", "abc bank", 2200);
            Van van1 = new Van("sw3245f", "brand b", "van 2", false, false, true);
            Driver d2 = new Driver("Driver 2", "87654321", "driver@email.com", "d2", ba2, van1);
            drivers.Add(d2);
            BankAccount ba3 = new BankAccount("2314567812345678", "abc bank", 1900);
            ExcursionBus b1 = new ExcursionBus("sh5678d", "brand c", "bus 3", false, false, true);
            Driver d3 = new Driver("Driver 3", "87654321", "driver@email.com", "d3", ba3, b1);
            drivers.Add(d3);
            BankAccount ba4 = new BankAccount("4321567812345678", "abc bank", 1900);
            ExcursionBus b2 = new ExcursionBus("sq0000d", "brand e", "bus 1", false, false, false);
            Driver d4 = new Driver("Driver 4", "87654321", "driver@email.com", "d4", ba3, b1);
            drivers.Add(d4);

            // Populate one customer
            // TODO (DIY)
            CreditCard card = new CreditCard("2341123443211234", "John", 5000);
            Customer c = new Customer("John", "98765432", "john@email.com", "c1", card);

            // Populate one admin
            Admin adm = new Admin("Supreme Leader", "84272813", "supreme@kim.kp", "34faba12");

            // dummy ride
            Ride ride1 = new Ride("r1", "pickup", "destination");
            ride1.customer = c;
            ride1.driver = d2;
            // The current ride
            Ride ride;
            
            // hihi if u can move ur codes below this while loop its appreciated tq!
            // leaving here to avoid conflict
            while (false) {

                Menu();
                Console.Write("Enter your option: ");
                option = Console.ReadLine();
                Console.WriteLine();

                // Make booking
                // TODO (DIY)
                if (option == "1") {
                    Console.Write("Destination: ");
                    string des = Console.ReadLine();
                    Console.Write("Pickup Point: ");
                    string pick = Console.ReadLine();

                    //Console.WriteLine("Pick vehicle:");
                    //Console.WriteLine("[a] Car");
                    //Console.WriteLine("[b] Van");
                    //Console.WriteLine("[c] Excursion Bus");
                    //string veh = Console.ReadLine();

                    Console.WriteLine("Available vehicles: ");
                    //List<Vehicle> vList = new List<Vehicle>();
                    //vList.Add(c1);
                    //vList.Add(van1);
                    //vList.Add(b1);
                    //vList.Add(b2);

                    DefaultVehicleAggregate agg1 = new DefaultVehicleAggregate();
                    agg1.addVehicle(c1);
                    agg1.addVehicle(van1);
                    agg1.addVehicle(b1);
                    agg1.addVehicle(b2);

                    DefaultVehicleIterator iter = agg1.createIterator(true);
                    

                    int i = 1;
                    while (iter.hasNext()) {
                        //Console.WriteLine("[" + i + "]Vehicle Type: " + iter.getNext().);
                        Vehicle vehi1 = iter.getNext();
                        Console.WriteLine("[" + i + "]License Plate: " + vehi1.LicensePlate + " Brand: " + vehi1.Brand + " Model: " + vehi1.Model);
                        i++;
                    }
                    /*Console.Write("Vehicle: ");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (iter.getNext().isAvailable == true) {
                        for (int v = 1; v < opt + 1; v++) {
                            Ride r1 = new Ride("1234", pick, des);
                            r1.driver.MyVehicle.Dri(d1);


                            if (Vehicle is Van) {
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
                            }
                        }
                    }*/



                }


                // Accept booking

                else if (option=="2") {
                    Console.Write("Accept driver? [Y/N] ");

                    string response = Console.ReadLine().Trim().ToLower();
                    if (response == "y") {
                        while (true) {
                            Console.WriteLine("Do you want to start ride? [Y/N] ");

                            string ans = Console.ReadLine().Trim().ToLower();
                            if (ans == "y") {
                                if (ans == "y") {
                                    RideStartedState start = new RideStartedState();
                                    start.startRide();
                                    break;
                                } else if (ans == "n") {
                                    continue;
                                }
                            }
                        }
                    } 
                    else if (response == "n") {
                        //cancel booking(vandana)
                    }

                }

                // Cancel booking(Customer)
                // TODO (DIY)
                else if (option == "3") {

                }

                // Start ride
                // TODO (DIY)
                else if (option == "4") {

                }

                // Make payment
                // TODO (DIY)
                else if (option == "5") {
                    Console.WriteLine("== Make payment by Credit Card ==");

                    // for testing
                    ride1.rideCtx.changeState(new RideDoneState(ride1.rideCtx));

                    // calculating
                    Console.WriteLine("Calculating fare...");
                    Console.WriteLine("Trip fare: " + ride1.Fare);
                    if (ride1.driver.MyVehicle.getHasFee()) {
                        Van vann = (Van)ride1.driver.MyVehicle;
                        Console.WriteLine("Booking fee: " + vann.BookingFee);
                    }

                    Console.Write("Pay by credit card? [Y/N] ");
                    string pay = Console.ReadLine();
                    Console.WriteLine();

                    if (pay == "y" || pay =="Y") {
                        ride1.rideCtx.entry();
                        Console.WriteLine("----");
                        ride1.rideCtx.exit();
                    } else if (pay=="n" || pay =="N") {
                        continue;
                    } else {
                        Console.WriteLine("Invalid input. Please try again.\n");
                        continue;
                    }
                    

                    Console.WriteLine();
                }

                // Rate driver
                // TODO (DIY)
                else if (option == "6") {
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

                }

                // Process feedback
                // TODO (DIY)
                else if (option == "7") {

                }

            }

            ConsoleMenu menu = new ConsoleMenu()
                .BeforeInteraction((m) => {
                    Console.WriteLine("Hello welcome to PickUpNow!\n" + new string('=', 28));
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

                    Console.WriteLine("Available vehicles: ");
                    //List<Vehicle> vList = new List<Vehicle>();
                    //vList.Add(c1);
                    //vList.Add(van1);
                    //vList.Add(b1);
                    //vList.Add(b2);

                    DefaultVehicleAggregate agg1 = new DefaultVehicleAggregate();
                    agg1.addVehicle(c1);
                    agg1.addVehicle(van1);
                    agg1.addVehicle(b1);
                    agg1.addVehicle(b2);

                    DefaultVehicleIterator iter = agg1.createIterator(true);
                    int i = 1;
                    while (iter.hasNext()) {
                        //Console.WriteLine("[" + i + "]Vehicle Type: " + iter.getNext().);
                        Console.WriteLine("[" + i + "] License Plate: " + iter.getNext().LicensePlate);
                        Console.WriteLine("[" + i + "] Brand: " + iter.getNext().Brand);
                        Console.WriteLine("[" + i + "] Model: " + iter.getNext().Model);
                        i++;
                    }
                    Console.WriteLine();
                    int opt = Convert.ToInt32(Console.ReadLine());
                    //if (agg1.createIterator(true))
                    //{
                    //    for (int i = 1; i < opt+1; i++)
                    //    {
                    //        if (Vehicle is Van)
                    //        {
                    //            Console.WriteLine("Deposit amount to be paid: $5");
                    //            Console.Write("Date and Time of booking:");
                    //            string datetime = Console.ReadLine();
                    //            Console.Write("Date and Time: " + datetime + " Type any key to confirm.");
                    //            Console.ReadLine();
                    //            Console.WriteLine("Deposit Deducted.");
                    //            Console.WriteLine("------Driver------");
                    //            Console.WriteLine("You have a new Customer!");
                    //            Console.WriteLine("Name: " + c.Name);
                    //            Console.WriteLine("Phone Number: " + c.contactNo);
                    //            Console.WriteLine("Email Address: " + c.emailAddress);
                    //            Console.WriteLine("Date and Time: " + datetime);
                    //        }
                    //    }
                    //}

                    // Populate Ride obj

                    // after choose driver
                    Console.Write("Accept driver? [Y/N] ");

                    string response = Console.ReadLine().Trim().ToLower();
                    if (response == "y") {
                        // accept booking (cae)
                    } else if (response == "n") {
                        //cancel booking(vandana)
                    }
                })
                .AddOption("Cancel booking", (m) => {
                })
                .AddOption("Make payment", (m) => {
                    // Make payment
                    // TODO (DIY)
                    while (true) {
                        Console.WriteLine("== Make payment by Credit Card ==");

                        // for testing
                        ride1.rideCtx.changeState(new RideDoneState(ride1.rideCtx));

                        // calculating
                        Console.WriteLine("Calculating fare...");
                        Console.WriteLine("Trip fare: " + ride1.Fare);
                        if (ride1.driver.MyVehicle.getHasFee()) {
                            Van vann = (Van)ride1.driver.MyVehicle;
                            Console.WriteLine("Booking fee: " + vann.BookingFee);
                        }

                        Console.Write("Pay by credit card? [Y/N] ");
                        string pay = Console.ReadLine();
                        Console.WriteLine();

                        if (pay == "y" || pay == "Y") {
                            ride1.rideCtx.entry();
                            Console.WriteLine("----");
                            ride1.rideCtx.exit();
                            Console.WriteLine();
                            //exit
                            break;
                        } else if (pay == "n" || pay == "N") {
                            //exit
                            Console.WriteLine();
                            break;
                        } else {
                            Console.WriteLine("Invalid input. Please try again.\n");
                            //retry
                            continue;
                        }                        
                    }
                    

                })
                .AddOption("Rate driver", (m) => {
                    Console.WriteLine("Ride ended.");
                    Console.Write("Rate driver [1-5] ");
                    string rate = Console.ReadLine();
                    int rating = Convert.ToInt32(rate);
                    Rating r = new Rating(c, d1);
                })

                // Drivers option // aaaaa
                .AddHeading("Driver")
                .AddOption("Accept booking", (m) => {
                    while (true) {
                        Console.WriteLine("Do you want to accept booking? [Y/N] ");

                        string ans = Console.ReadLine().Trim().ToLower();
                        if (ans == "y") {

                        } else if (ans == "n") {
                            continue;
                        }
                    }
                })
                .AddOption("Start ride", (m) => {
                    while (true) {
                        Console.WriteLine("Do you want to start ride? [Y/N] ");

                        string ans = Console.ReadLine().Trim().ToLower();
                        if (ans == "y") {

                        } else if (ans == "n") {
                            continue;
                        }
                    }
                })

                // Admins option
                .AddHeading("Admin")
                .AddOption("Process rating", (m) => {
                })
                .AddHeading()
                .AddExitOption("Exit");

            menu.DisplayInteraction();

            Console.WriteLine("Until next time! Press any key to exit the program.");
            Console.ReadKey();
        }

        static void Menu() {
            Console.WriteLine("Hello welcome to PickUpNow!");
            Console.WriteLine("===========================");
            Console.WriteLine("MENU");
            Console.WriteLine("=====");
            Console.WriteLine("[1] Make booking");
            Console.WriteLine("[2] Accept booking");
            Console.WriteLine("[3] Cancel booking");
            Console.WriteLine("[4] Start ride");
            Console.WriteLine("[5] Make payment");
            Console.WriteLine("[6] Rate driver");
            Console.WriteLine("[7] Process rating");
            Console.WriteLine("[0] Exit");
            Console.WriteLine();
        }
    }
}
