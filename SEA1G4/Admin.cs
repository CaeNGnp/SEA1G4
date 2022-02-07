using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    class Admin : User, RatingObserver
    {
        private FollowUp[] followUps;

        public void update(Rating r)
        {
            this.rating = r;
        }
    }
}
