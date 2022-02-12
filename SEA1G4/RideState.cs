namespace SEA1G4 {
    public interface RideState {
        /// <summary>
        /// Triggered when booking needs to be accepted
        /// </summary>
        void acceptBooking();

        /// <summary>
        /// Triggered when booking needs to be cancelled
        /// </summary>
        void cancelBooking();

        /// <summary>
        /// Triggered when ride needs to be started
        /// </summary>
        void startRide();

        /// <summary>
        /// Triggered when ride needs to be ended
        /// </summary>
        void endRide();

        /// <summary>
        /// Triggered when ride needs to be rated
        /// </summary>
        void giveRating();

        /// <summary>
        /// Triggered when ride needs to be paid for
        /// </summary>
        void makePayment();

        /// <summary>
        /// Triggered when notification needs to be sent
        /// </summary>
        void sendNotification();
    }
}
