namespace SEA1G4 {
    public interface RatingSubject {
        void registerRatingObserver(RatingObserver o);

        void removeRatingObserver(RatingObserver o);

        void notifyRatingObservers(Rating rating);
    }
}
