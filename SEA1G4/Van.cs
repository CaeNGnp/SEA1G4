using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class Van : Vehicle
    {
        private double deposit;
        private double bookingFee;

        public Van(string lp, string bd, string md, bool hd, bool hf, double dep, double bf, bool av) : base(lp, bd, md,hd,hf, av)
        {
            deposit = dep;
            bookingFee = bf;
        }

        public double BookingFee {
            set { bookingFee = value; }
            get { return bookingFee; }
        }
    }
}
