using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    class DefaultVehicleIterator
    {
        private Vehicle[] vehicles;
        private int currentVehicle;

        public Vehicle getNext();
        public DefaultVehicleIterator();

        public DefaultVehicleIterator(Vehicle[] vehi, int currentVehi)
        {
            vehicles = vehi;
            currentVehicle = currentVehi;
        }
    }
}
