using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class VehicleList
    {
        public List<Vehicle> vList;

        public VehicleList()
        {
            vList = new List<Vehicle>();
        }

        public void addVehicle(Vehicle v)
        {
            vList.add(v);
        }

        public VehicleIterator createIterator(bool available)
        {
            return new VehicleIterator(this, available);
        }
    }
}
