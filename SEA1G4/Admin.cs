using System;
using System.Collections.Generic;

namespace SEA1G4 {
    public class Admin : User, RatingObserver {
        private List<FollowUp> followUps;

        public Admin(string n, string c, string e, string id) : base(n, c, e, id) {
            followUps = new List<FollowUp>();
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
                    break;
                } else if (response == "n") {
                    // 4.2.	Use case ends.
                    return;
                }
            }

            string followUp;

            while (true) {
                // 3.	System prompts admin whether to create a follow-up action.
                Write("Write your follow up action description: ");

                // 6.	Admin supplies the follow-up description.
                followUp = Console.ReadLine().Trim();
                if (followUp.Length == 0) {
                    // 6.1.	System sends an error message to supply a description
                    continue;
                }
                break;
            }

            // 7. System adds the follow-up action into the admin’s archive
            followUps.Add(new FollowUp(followUp));
        }
    }
}
