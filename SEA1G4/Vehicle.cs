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
        private bool hasDeposit;
        private bool hasFee;

        public Vehicle(string lp, string bd, string md, bool hd, bool hf)
        {
            licensePlate = lp;
            brand = bd;
            model = md;
            hasDeposit = hd;
            hasFee = hf;
        }

        public bool getHasFee() {
            bool hasFee = true;

            return hasFee;
        }
    }
}
