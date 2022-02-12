using System.Collections.Generic;

namespace SEA1G4 {
    public class Rating {
        protected FeedbackStrategy feedbackStrategy;
        private List<RatingObserver> observers;

        public User Author { get; private set; }
        public User RatingFor { get; private set; }
        public string Feedback { get; private set; }
        public int RatingNum { get; private set; }
        public Ride ride { get; set; }

        public Rating(User author, User ratingFor) {
            observers = new List<RatingObserver>();

            Author = author;
            RatingFor = ratingFor;

            if(author is Customer) {
                feedbackStrategy = new FeedbackFromCustomer();
            } else {
                feedbackStrategy = new FeedbackFromDriver();
            }
        }

        public void setRating(int rating) {
            RatingNum = rating;
        }

        public void setFeedback(string feedback) {
            Feedback = feedbackStrategy.processFeedback(feedback);
        }

    }
}
