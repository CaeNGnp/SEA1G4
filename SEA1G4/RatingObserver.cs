namespace SEA1G4 {
    public interface RatingObserver {
        /// <summary>
        /// Triggered when rating updated.
        /// </summary>
        /// <param name="r"></param>
        void onRatingUpdated(Rating r);
    }
}
