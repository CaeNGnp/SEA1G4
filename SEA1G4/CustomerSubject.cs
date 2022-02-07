using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    interface CustomerSubject
    {
        public registerObserver(CustomerObserver co);
        public removeObserver(CustomerObserver co);
        public notifyObservers();
    }
}
