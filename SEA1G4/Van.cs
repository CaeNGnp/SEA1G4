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

        public Van(double dep, double bf)
        {
            deposit = dep;
            bookingFee = bf;
        }
    }
}
