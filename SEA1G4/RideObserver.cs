using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public interface RideObserver
    {
        public abstract void update(Ride r);
    }
}
