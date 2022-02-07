using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class Admin : User, RatingObserver
    {
        private FollowUp[] followUps;
        private Rating rating;

        public Admin(string n, string c, string e, string id) : base(n, c, e, id) {

        } 
        public void update(Rating r)
        {
            this.rating = r;
        }

      
    }
}
