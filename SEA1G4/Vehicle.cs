﻿using System;
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

        public Vehicle(string lp, string bd, string md, bool hd, bool hf, bool av)
        {
            licensePlate = lp;
            brand = bd;
            model = md;
            hasDeposit = hd;
            hasFee = hf;
            available = av;
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
