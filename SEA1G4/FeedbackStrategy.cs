namespace SEA1G4 {
    public interface FeedbackStrategy {
        string processFeedback(string feedback);
    }

    public class FeedbackFromCustomer : FeedbackStrategy {

        public string processFeedback(string feedback) {
            return feedback;
        }

    }

    public class FeedbackFromDriver : FeedbackStrategy {
        public string processFeedback(string feedback) {
            // Feedback unapplicable for customer
            return null;
        }

    }


}
