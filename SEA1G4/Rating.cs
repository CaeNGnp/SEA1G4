using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    class Rating
    {
        protected FeedbackStrategy feedbackStrategy;
        private int rating;
        private string feedback;
        private User author;
        private User ratingFor;


        public void setRating(int rating)
        {
            rating = rating;
        }

        public void setFeedback(string feedback)
        {
            FeedbackStrategy.setFeedback(feedback);
        }
    }
}
