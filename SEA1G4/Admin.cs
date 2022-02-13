using System;

namespace SEA1G4 {
    public class Admin : User, RatingObserver {
        private FollowUpEnumerable followUps;

        public FollowUpEnumerable FollowUps {
            get {
                return followUps;
            }
        }

        public Admin(string n, string c, string e, string id) : base(n, c, e, id) {
            followUps = new FollowUpEnumerable();
        }

        public void onRatingUpdated(Rating r) {
            // 2. System notifies admin about the rating and its details
            WriteLine($"Author: {r.Author.Name}");
            WriteLine($"Rating for: {r.RatingFor.Name}");
            WriteLine($"Rating (1 to 5): {r.RatingNum}");
            WriteLine($"Feedback message: {r.Feedback}");

            while (true) {
                // 3.	System prompts admin whether to create a follow-up action.
                Write("Do you want to create a new follow up action? [Y/N] ");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "y") {
                    // 4.	Admin replies with a “Yes”.
                    break;
                } else if (response == "n") {
                    // 4.1.	Admin replies with a “No”.
                    // 4.2.	Use case ends.
                    return;
                }
            }

            string action;

            while (true) {
                // 5.	System prompts admin to provide an input to describe the follow up action being taken.
                Write("Write your follow up action description: ");

                // 6.	Admin supplies the follow-up description.
                action = Console.ReadLine().Trim();
                if (action.Length == 0) {
                    // 6.1.	Admin provides an empty description
                    // 6.2.	System sends an error message to supply a description
                    WriteLine("You must provide a description.");
                    // 6.3.	System goes back to step 5
                    continue;
                }
                break;
            }

            // 7. System adds the follow-up action into the admin’s archive
            followUps.addFollowUp(new FollowUp(action, DateTime.Now));
        }
    }
}
