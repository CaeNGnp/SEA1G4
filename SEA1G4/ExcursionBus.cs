using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class ExcursionBus : Vehicle
    {
        private double deposit = 12 ;

        public ExcursionBus(string lp, string bd, string md, bool hd, bool hf, bool av) : base(lp, bd, md, hd, hf, av)
        {
        }

        public double Deposit
        {
            set { deposit = value; }
            get { return deposit; }
        }
    }
}
