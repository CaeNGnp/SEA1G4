using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    interface FeedbackStrategy
    {
        void feedbackStrategy(string feedback);

    }

    public class FeedbackFromCustomer : FeedbackStrategy
    {
        public void setFeedback(string feedback)
        {
            Console.WriteLine("Feedback Received!");
        }
    }

    public class FeedbackFromDriver : FeedbackStrategy
    {
        public void setFeedback(string feedback)
        {
            Console.WriteLine("");
        }
    }
}
