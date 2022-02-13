using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class DefaultVehicleIterator
    {
        int position = 0;
        List<Vehicle> vehicleList;
        private bool available;

        public DefaultVehicleIterator(DefaultVehicleAggregate vehicleAggregate, bool avail)
        {
            vehicleList = vehicleAggregate.vList;
            available = avail;
        }
        public Vehicle getNext()
        {
            Vehicle availVehicle = vehicleList[position];
            ++position;
            while ((position < vehicleList.Count()) &&
                   (vehicleList[position].isAvailable != available))
                ++position; // skip 
            return availVehicle;
        }

        public bool hasNext()
        {
            return position <= vehicleList.Count();
        }

       
    }
}

