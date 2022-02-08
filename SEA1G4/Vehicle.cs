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
        private bool available;
        private Driver dri;


        public Driver Dri { get; set; }
        public Vehicle(string lp, string bd, string md, bool hd, bool hf, bool av, Driver d)
        {
            licensePlate = lp;
            brand = bd;
            model = md;
            hasDeposit = hd;
            hasFee = hf;
            available = av;
            dri = d;
        }

        public string LicensePlate {
            set { licensePlate = value; }
            get { return licensePlate; }
        }

        public string Brand {
            set { brand = value; }
            get { return brand; }
        }
        public string Model {
            set { model = value; }
            get { return model; }
        }

        public bool getHasFee() {
            bool hasFee = true;

            return hasFee;
        }

        public bool isAvailable
        {
            set { available = value; } 
            get { return available; }
        }
    }
}
