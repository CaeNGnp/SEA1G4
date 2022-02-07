using System.Collections.Generic;

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
