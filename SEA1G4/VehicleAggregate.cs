using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public interface VehicleAggregate
    {
        public VehicleIterator createIterator();
    }
}
