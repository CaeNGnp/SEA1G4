using System;

namespace SEA1G4 {
    public class FollowUp {
        public string Action { get; private set; }
        public DateTime SubmittedTime { get; private set; }

        public FollowUp(string action, DateTime submittedTime) {
            Action = action;
            SubmittedTime = submittedTime;
        }
    }
}
