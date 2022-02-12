namespace SEA1G4 {
    public class Vehicle {
        private string licensePlate;
        private string brand;
        private string model;
        private bool hasDeposit;
        private bool hasFee;
        private bool available;
        private Driver driver;


        public Driver Driver {
            get {
                return driver;
            }
            set { driver = value; }
        }

        public Vehicle(string lp, string bd, string md, bool hd, bool hf, bool av) {
            licensePlate = lp;
            brand = bd;
            model = md;
            hasDeposit = hd;
            hasFee = hf;
            available = av;
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

        public bool HasFee {
            set { hasFee = value; }
            get { return hasFee; }
        }

        public bool isAvailable {
            set { available = value; }
            get { return available; }
        }
    }
}
