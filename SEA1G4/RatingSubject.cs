using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public interface RatingSubject
    {
        void registerObserver(RatingObserver o);

        void removeObserver(RatingObserver o);

        void notifyObservers();
    }
}
