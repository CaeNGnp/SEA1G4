using System.Collections.Generic;

namespace SEA1G4 {
    public class Admin : User, RatingObserver {
        private List<FollowUp> followUps;

        public Admin(string n, string c, string e, string id) : base(n, c, e, id) {
            followUps = new List<FollowUp>();
        }

        public void update(int r, string f) {
            throw new System.NotImplementedException();
        }
    }
}
