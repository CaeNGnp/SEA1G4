using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class Van : Vehicle
    {
        private double deposit = 5;
        private double bookingFee = 3;

        public Van(string lp, string bd, string md, bool hd, bool hf, bool av, Driver d) : base(lp, bd, md, hd, hf, av, d)
        {

        }

        public double BookingFee {
            set { bookingFee = value; }
            get { return bookingFee; }
        }

        public double Deposit
        {
            set { deposit = value; }
            get { return deposit; }
        }
    }
}
