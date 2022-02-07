using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class DefaultVehicleAggregate
    {
        public List<Vehicle> vList;

        public DefaultVehicleAggregate()
        {
            vList = new List<Vehicle>();
        }

        public void addVehicle(Vehicle v)
        {
            vList.Add(v);
        }

        public DefaultVehicleIterator createIterator(bool available)
        {
            return new DefaultVehicleIterator(this, available);
        }
    }
}

