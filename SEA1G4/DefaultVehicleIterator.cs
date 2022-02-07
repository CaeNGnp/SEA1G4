using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public interface DefaultVehicleIterator
    {
        int position = 0;
        List<Vehicle> vehicleList;
        private bool available;

        public DefaultVehicleIterator(DefaultVehicleAggregate vList, bool avail)
        {
            vehicleList = vList;
            available = avail;
        }
        public Vehicle getNext()
        {
            DefaultVehicleAggregate availVehicle = vehicleList[position];
            ++position;
            while ((position < vehicleList.Count()) &&
                   (vehicleList[position].isAvailable != available))
                ++position; // skip 
            return availVehicle;
        }

        public bool hasNext()
        {
            return position < vehicleList.Count();
        }
    }
}

