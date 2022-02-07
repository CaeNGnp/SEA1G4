using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEA1G4
{
    public interface FeedbackStrategy
    {
        bool setFeedback();

    }

    public class FeedbackFromCustomer: FeedbackStrategy
    {

        public bool setFeedback()
        {
            Console.WriteLine("Feedback Received!");
            return true;
        }
    }

    public class FeedbackFromDriver : FeedbackStrategy
    {
        public bool setFeedback()
        {
            Console.WriteLine("Feedback unapplicable.");
            return false;
        }
    }
}
