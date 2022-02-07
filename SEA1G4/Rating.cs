using System.Collections.Generic;

namespace SEA1G4 {
    public class Rating : RatingSubject {
        protected FeedbackStrategy feedbackStrategy;
        private List<RatingObserver> observers;

        public User Author { get; private set; }
        public User RatingFor { get; private set; }
        public string Feedback { get; private set; }
        public int RatingNum { get; private set; }

        public Rating(User author, User ratingFor) {
            observers = new List<RatingObserver>();

            Author = author;
            RatingFor = ratingFor;
        }

        public void setRating(int rating) {
            RatingNum = rating;
        }

        public void setFeedback(string feedback) {
            Feedback = feedbackStrategy.processFeedback(feedback);
        }

        public void registerObserver(RatingObserver o) {
            observers.Add(o);
        }

        public void removeObserver(RatingObserver o) {
            observers.Remove(o);
        }

        public void notifyObservers() {
            foreach (RatingObserver o in observers) {
                o.update(this);
            }
        }

        
    }
}
