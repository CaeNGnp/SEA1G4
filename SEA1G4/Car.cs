using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class Car : Vehicle
    {
        public Car(string lp, string bd, string md, bool hd, bool hf, bool av, Driver d) : base(lp, bd, md, hd, hf, av, d) { }
            
    }
}
