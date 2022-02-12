namespace SEA1G4 {
    public interface FeedbackStrategy {
        /// <summary>
        /// Processes a feedback message given by the User.
        /// </summary>
        /// <returns>The new feedback message.</returns>
        string processFeedback(string feedback);
    }
}
