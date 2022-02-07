using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    class Rating : RatingSubject
    {
        protected FeedbackStrategy feedbackStrategy;
        private int rating;
        private string feedback;
        private User author;
        private User ratingFor;

        public Rating()
        {
            RatingObserver observer = new RatingObserver();
        }

        public void setRating(int rating)
        {
            rating = rating;
        }

        public void setFeedback(string feedback)
        {
            FeedbackStrategy.setFeedback(feedback);
        }

        public void registerObserver(RatingObserver o)
        {
            observer.Add(o);
        }

        public void removeObserver(RatingObserver o)
        {
            observer.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (RatingObserver o in observer)
                o.update(rating, feedback);
        }
       
        public void measurementsChanged()
        {
            notifyObservers();
        }
    }
}
