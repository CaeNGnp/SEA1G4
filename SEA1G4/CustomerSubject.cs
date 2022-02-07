using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public interface CustomerSubject
    {
        void registerObserver(CustomerObserver co);
        void removeObserver(CustomerObserver co);
        void notifyObservers();
    }
}
