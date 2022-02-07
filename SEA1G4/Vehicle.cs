using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class Vehicle
    {
        private string licensePlate;
        private string brand;
        private string model;

        public Vehicle(string lp, string bd, string md)
        {
            licensePlate = lp;
            brand = bd;
            model = md;
        }

        public bool hasFee() {
            bool hasfee = true;

            return hasfee;
        }
    }
}
