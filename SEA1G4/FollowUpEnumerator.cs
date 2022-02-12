using System.Collections;
using System.Collections.Generic;

namespace SEA1G4 {
    public class FollowUpEnumerable : IEnumerable<FollowUp> {
        private List<FollowUp> followUps;

        public FollowUpEnumerable() {
            followUps = new List<FollowUp>();
        }

        public void addFollowUp(FollowUp followUp) {
            followUps.Add(followUp);
        }

        public IEnumerator GetEnumerator() {
            return followUps.GetEnumerator();
        }

        IEnumerator<FollowUp> IEnumerable<FollowUp>.GetEnumerator() {
            return followUps.GetEnumerator();
        }
    }
}
