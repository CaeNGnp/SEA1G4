namespace SEA1G4 {
    public interface RideState {
        /// <summary>
        /// Triggered when booking needs to be accepted by driver
        /// </summary>
        void acceptBooking();

        /// <summary>
        /// Triggered when booking needs to be cancelled by customer
        /// </summary>
        void cancelBooking();

        /// <summary>
        /// Triggered when ride needs to be started by driver
        /// </summary>
        void startRide();

        /// <summary>
        /// Triggered when ride needs to be ended by driver
        /// </summary>
        void endRide();

        /// <summary>
        /// Triggered when ride needs to be rated by customer
        /// </summary>
        void giveRating();

        /// <summary>
        /// Triggered when ride needs to be paid by customer
        /// </summary>
        void makePayment();

        /// <summary>
        /// Triggered when notification needs to be sent at the top of the main menu
        /// </summary>
        void sendNotification();
    }
}
