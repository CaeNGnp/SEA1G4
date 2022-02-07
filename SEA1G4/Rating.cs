using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public class Rating : RatingSubject
    {
        protected FeedbackStrategy feedbackStrategy;
        private int rating;
        private string feedback;
        private User author;
        private User ratingFor;
        private List<RatingObserver> observers;

        public Rating()
        {
            observers = new List<RatingObserver>();
        }

        public void setRating(int rating)
        {
            this.rating = rating;
        }

        public void setFeedback(string feedback)
        {
            bool val = feedbackStrategy.setFeedback();
            if (val) {
                this.feedback = feedback;
            }
        }

        public void registerObserver(RatingObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(RatingObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (RatingObserver o in observers)
                o.update(rating, feedback);
        }
       
        public void measurementsChanged()
        {
            notifyObservers();
        }
    }
}
