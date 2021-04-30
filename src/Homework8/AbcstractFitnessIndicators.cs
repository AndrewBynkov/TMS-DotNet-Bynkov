using System;

namespace Homework8
{
    public abstract class AbcstractFitnessIndicators
    {
        public readonly DateTime _timeNow = DateTime.Now;

        /// <summary>
        /// UserPulse
        /// </summary>
        public int Pulse { get; set; }

        /// <summary>
        /// UserSteps
        /// </summary>
        public int Steps { get; set; }

        /// <summary>
        /// UserAveageSpeed
        /// </summary>
        public double AverageSpeed { get; set; }

        /// <summary>
        /// UserDistanceCovered
        /// </summary>
        public double Distanse { get; set; }

        /// <summary>
        /// FloorsPassed
        /// </summary>
        public int FloorsPassed { get; set; }
    }
}
