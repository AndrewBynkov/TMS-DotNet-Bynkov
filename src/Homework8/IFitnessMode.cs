namespace Homework8
{
    public interface IFitnessMode
    {

        /// <summary>
        /// Average Speed
        /// </summary>
        /// <returns></returns>
        public double UserAverageSpeed();

        /// <summary>
        /// Distanse
        /// </summary>
        /// <returns></returns>
        public double UserDistanse();

        /// <summary>
        /// Pulse Rate
        /// </summary>
        /// <returns></returns>
        public int UserPulse();

        /// <summary>
        /// Count steps
        /// </summary>
        /// <returns></returns>
        public int UserSteps();

        /// <summary>
        /// Get info mode
        /// </summary>
        public void GetInfo();
    }
}
