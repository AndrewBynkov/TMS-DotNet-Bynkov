using System;
using System.Linq;

namespace Homework8
{
    public class FitnessModeRun : AbcstractFitnessIndicators, IFitnessMode
    {
        public FitnessModeRun(int timeRun)
        {
            _timeRun = timeRun;
        }

        /// <summary>
        /// TimeUserRun
        /// </summary>
        private double _timeRun;

        /// <summary>
        /// Distanse Run
        /// </summary>
        public double DistanseRun { get; set; }

        public double UserDistanse() => DistanseRun = AverageSpeed * _timeRun;

        public double UserAverageSpeed() => AverageSpeed = DistanseRun / _timeRun;

        public int UserPulse()
        {
            throw new System.NotImplementedException();
        }

        public int UserSteps()
        {
            throw new System.NotImplementedException();
        }


        public void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
