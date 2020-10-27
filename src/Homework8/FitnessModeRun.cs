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

        public double UserDistanseWalking()
        {
            throw new System.NotImplementedException();
        }

        public double UserAverageSpeed()
        {
            throw new System.NotImplementedException();
        }
        public int UserPulseWalking()
        {
            throw new System.NotImplementedException();
        }

        public int UserSteps()
        {
            throw new System.NotImplementedException();
        }

        public void GetInfoWalking()
        {
            throw new System.NotImplementedException();
        }
    }
}
